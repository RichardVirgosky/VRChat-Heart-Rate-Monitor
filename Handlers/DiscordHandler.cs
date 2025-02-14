using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using DiscordRPC;

namespace VRChatHeartRateMonitor
{
    internal class DiscordHandler
    {
        private DiscordRpcClient _client;

        private Stopwatch _presenceStopwatch = new Stopwatch();
        private DateTime _presenceStartTime = DateTime.UtcNow;
        public Func<ushort> RequestHeartRate { get; set; }

        public async void Start(string activeText, string idleText, string stateText)
        {
            try
            {
                _client = new DiscordRpcClient("1337796535647211541");
                _client.Initialize();

                ushort? lastRenderedHeartRate = null;

                while (!_client.IsDisposed)
                {
                    ushort currentHeartRate = RequestHeartRate();

                    if (currentHeartRate != lastRenderedHeartRate && (!_presenceStopwatch.IsRunning || _presenceStopwatch.Elapsed.TotalSeconds > 15))
                    {
                        string state = String.Format(stateText, currentHeartRate);
                        _client?.SetPresence(new RichPresence()
                        {
                            Details = String.Format((currentHeartRate > 0 ? activeText : idleText), currentHeartRate),
                            State = state,
                            Assets = new Assets()
                            {
                                LargeImageKey = "small_logo",
                                LargeImageText = state,
                                SmallImageKey = "hr_" + currentHeartRate,
                                SmallImageText = state
                            },
                            Timestamps = new Timestamps() { Start = _presenceStartTime },
                            Buttons = new Button[] { new Button() { Label = "Get the app here!", Url = "https://github.com/RichardVirgosky/VRChat-Heart-Rate-Monitor" } }
                        });

                        lastRenderedHeartRate = currentHeartRate;

                        _presenceStopwatch.Restart();
                    }

                    await Task.Delay(100);
                }
            }
            catch (Exception) { }
        }

        public void Stop()
        {
            _client?.ClearPresence();
            _client?.Dispose();
        }
    }
}
