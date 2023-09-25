using CodeWalker.GameFiles;
using CodeWalker.Project;
using Newtonsoft.Json;
using System;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWalker.CustomExtensions
{
    public class SdkRequest
    {
        [JsonProperty("assetname")]
        public string AssetName { get; set; }
        [JsonProperty("filePath")]
        public string FilePath { get; set; }
        [JsonProperty("requestType")]
        public string RequestType { get; set; }
    }

    public class SdkFileReloader
    {
        public EventHandler<SdkRequest> OnSdkRefresh { get; set; }
        private Task reloaderLoopTask;
        private HttpListener httpListener;
        private CancellationTokenSource cancellationTokenSource;

        public SdkFileReloader()
        {
        }
        public void StartSdkListener()
        {
            cancellationTokenSource = new CancellationTokenSource();
            //OnSdkRefresh += ProjectForm_OnSdkRefresh;
            httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:8001/");

            try
            {
                httpListener.Start();
            }
            catch (Exception)
            {


            }


            Console.WriteLine("Listening on port 8001...");

            reloaderLoopTask = Task.Run(() =>
            {
                try
                {
                    ListenerLoop();
                }
                catch (TaskCanceledException)
                {
                }

            }, cancellationTokenSource.Token);
        }
        private async void ListenerLoop()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                var contextTask = httpListener.GetContextAsync();
                var completedTask = await Task.WhenAny(contextTask, Task.Delay(-1, cancellationTokenSource.Token));

                HttpListenerContext context;

                if (completedTask == contextTask && !contextTask.IsFaulted)
                {
                    context = await contextTask;
                }
                else
                {
                    return;
                }


                HttpListenerRequest req = context.Request;

                Console.WriteLine($"Received request for {req.Url}");

                System.IO.Stream body = req.InputStream;
                System.Text.Encoding encoding = req.ContentEncoding;
                System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);
                if (req.ContentType != null)
                {
                    Console.WriteLine("Client data content type {0}", req.ContentType);
                }
                string s = reader.ReadToEnd();
                body.Close();
                reader.Close();

                SdkRequest refreshRequest = JsonConvert.DeserializeObject<SdkRequest>(s);

                HttpListenerResponse resp = context.Response;
                resp.Headers.Set("Content-Type", "text/plain");


                string data = "Hello there!";
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                resp.ContentLength64 = buffer.Length;

                Stream ros = resp.OutputStream;
                ros.Write(buffer, 0, buffer.Length);

                OnSdkRefresh.Invoke(this, refreshRequest);
            }
        }
        public void StopSdkListener()
        {
            httpListener.Stop();
            cancellationTokenSource.Cancel();
        }

    }
}
