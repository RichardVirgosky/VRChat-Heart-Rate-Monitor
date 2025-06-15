using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using BuildSoft.VRChat.Osc;
using BuildSoft.VRChat.Osc.Chatbox;
using System.Threading;

namespace VRChatHeartRateMonitor
{
    internal class VRChatOscHandler
    {
        private CancellationTokenSource _cancellationTokenSource;

        public Func<ushort> RequestHeartRate { get; set; }
        public Func<ushort> RequestAverageHeartRate { get; set; }

        public async void Start(bool useChatbox, string chatboxText, bool useAvatar, string avatarParameter, string oscAddress)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            Stopwatch chatboxStopwatch = new Stopwatch();

            if (useChatbox)
                chatboxStopwatch.Start();

            ushort lastChatboxHeartRate = 0;
            ushort lastAvatarHeartRate = 0;

            string[] oscAddressArray = oscAddress.Split(':');

            if (oscAddressArray.Length == 2)
            {
                OscConnectionSettings.VrcIPAddress = oscAddressArray[0];
                OscConnectionSettings.SendPort = int.Parse(oscAddressArray[1]);
            }

            while (_cancellationTokenSource != null && !_cancellationTokenSource.IsCancellationRequested)
            {
                ushort currentHeartRate = RequestHeartRate();
                ushort averageHeartRate = RequestAverageHeartRate();

                if (useChatbox && currentHeartRate > 0 && ((lastChatboxHeartRate != currentHeartRate && chatboxStopwatch?.Elapsed.TotalSeconds >= 2) || chatboxStopwatch?.Elapsed.TotalSeconds >= 5))
                {
                    OscChatbox.SendMessage(chatboxText.Replace("{HR}", currentHeartRate.ToString()).Replace("{I}", (currentHeartRate < lastChatboxHeartRate ? "▼" : "▲")).Replace("{AVG}", averageHeartRate.ToString()), true, false);

                    chatboxStopwatch?.Restart();

                    lastChatboxHeartRate = currentHeartRate;
                }

                if (useAvatar && lastAvatarHeartRate != currentHeartRate)
                {
                    OscParameter.SendAvatarParameter(avatarParameter, (int)currentHeartRate);
                    OscParameter.SendAvatarParameter(avatarParameter, (currentHeartRate - 127f) / 127f);

                    lastAvatarHeartRate = currentHeartRate;
                }

                await Task.Delay(100);
            }
        }

        public void Stop()
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = null;
        }
    }
}
