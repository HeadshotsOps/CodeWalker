using CodeWalker.GameFiles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CodeWalker.CustomExtensions
{
    public class SdkGameFileService
    {
        static readonly string sIntermediateFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Mojito Sdk/intermediate/";
        static readonly string sGameFileServerEndpoint = "http://localhost:5025/";
        static readonly string sBlenderEndpoint = "http://localhost:1337";
        static string GetGameFileServerEndpoint(string endpoint)
        {
            return sGameFileServerEndpoint + endpoint;
        }

        private static string GetIntermediatePathForAsset(string assetPath)
        {
            string fileName = Path.GetFileName(assetPath) + ".xml";
            return sIntermediateFolderPath + fileName;
        }

        private static readonly HttpClient client = new HttpClient();

        public static async Task GameFileToXml(string assetpath)
        {
            string fileName = Path.GetFileName(assetpath) + ".xml";
            string jsonStr = JsonConvert.SerializeObject(new { inputpath = assetpath, outputpath = GetIntermediatePathForAsset(assetpath)});

            var buffer = Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(GetGameFileServerEndpoint("file/gamefile_to_xml"), byteContent);
        }

        public static async Task LoadInBlender(string assetPath)
        {
            string jsonStr = JsonConvert.SerializeObject(new { asset_path = assetPath });

            var form = new MultipartFormDataContent();

            form.Add(new StringContent(assetPath), "asset_path");
            form.Add(new StringContent((!assetPath.Contains("rpf:\\")).ToString()), "can_reload");

            var response = await client.PostAsync(sBlenderEndpoint, form);
        }
    }
}
