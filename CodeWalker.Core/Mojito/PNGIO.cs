using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWalker.Core.Mojito
{
    public class PNGIO
    {
        public static byte[] GetDDSFile(string pngFilePath)
        {
            string ddsCache = Path.Combine(@"C:\Users\catta\AppData\Local\Mojito Sdk\ddscache", Path.GetFileNameWithoutExtension(pngFilePath) + ".dds");



            Process nvcompressProcess = new Process
            {
                StartInfo =
                {
                    FileName = "nvcompress",
                    Arguments = $"-rgb -silent -bc3 \"{pngFilePath}\" \"{ddsCache}\"",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                }
            };
            nvcompressProcess.Start();

            nvcompressProcess.WaitForExit();

            byte[] ddsData = File.ReadAllBytes(ddsCache);
            File.Delete(ddsCache);
            return ddsData;
        }
    }
}
