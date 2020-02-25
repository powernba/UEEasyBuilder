using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Classes
{
    class Copier
    {
        async public Task Copy(String source, String destination) {

            DirectoryInfo sourceDir = new DirectoryInfo(source);
            DirectoryInfo destDir = new DirectoryInfo(destination);
            if (!sourceDir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Could not find directory: " + source);
            }

            DirectoryInfo[] dirs = sourceDir.GetDirectories();

            if (!destDir.Exists)
            {
                Directory.CreateDirectory(destination);
            }

            FileInfo[] files = sourceDir.GetFiles();

            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destination, file.Name);
                file.CopyTo(temppath, false);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destination, subdir.Name);
                Copy(subdir.FullName,temppath);
            }
        }
        public async Task Test()
        {
            await Task.Delay(5000);
        }
    }
}
