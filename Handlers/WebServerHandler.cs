using System;
using System.Net;
using System.Text;

namespace VRChatHeartRateMonitor
{
    internal class WebServerHandler
    {
        private HttpListener _httpListener;
        public Func<ushort> RequestHeartRate { get; set; }

        public async void Start(ushort httpPort, string html)
        {
            try
            {
                _httpListener = new HttpListener();
                _httpListener.Prefixes.Clear();
                _httpListener.Prefixes.Add("http://localhost:" + httpPort + "/");
                _httpListener.Start();

                while (_httpListener?.IsListening == true)
                {
                    try
                    {
                        var context = await _httpListener.GetContextAsync();
                        var response = context.Response;

                        byte[] buffer = Encoding.UTF8.GetBytes(String.Format(html, RequestHeartRate()));
                        response.ContentLength64 = buffer.Length;

                        await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
                        response.Close();
                    }
                    catch (ObjectDisposedException){}
                }
            }
            catch (Exception){}
        }

        public void Stop()
        {
            if (_httpListener?.IsListening == true)
            {
                _httpListener.Stop();
                _httpListener.Close();
            }

            _httpListener = null;
        }
    }
}
