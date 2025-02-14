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

        private static readonly string[] chatboxAppearanceTemplates = {
            "♥",
            "💖",
            "💓",
            "💔",
            "💕",
            "💘"
        };

        public async void Start(bool useChatbox, ushort chatboxAppearance, bool useAvatar, string avatarParameter, string oscAddress)
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
                ushort heartRate = RequestHeartRate();

                if (useChatbox && ((lastChatboxHeartRate != heartRate && chatboxStopwatch?.Elapsed.TotalSeconds >= 2) || chatboxStopwatch?.Elapsed.TotalSeconds >= 5))
                {
                    OscChatbox.SendMessage($"{chatboxAppearanceTemplates.ElementAt(chatboxAppearance)} {heartRate} {(heartRate < lastChatboxHeartRate ? "▼" : "▲")}", true, false);

                    chatboxStopwatch?.Restart();

                    lastChatboxHeartRate = heartRate;
                }

                if (useAvatar && lastAvatarHeartRate != heartRate)
                {
                    OscParameter.SendAvatarParameter(avatarParameter, (heartRate - 127f) / 127f);

                    lastAvatarHeartRate = heartRate;
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
