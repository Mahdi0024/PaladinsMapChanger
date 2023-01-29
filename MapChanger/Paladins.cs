using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapChanger
{
    public static class Paladins
    {
        public static string FindPaladinsFolder(string path)
        {
            try
            {
                var dirs = Directory.GetDirectories(path);
                var matchingDir = dirs.Where(IsPaladinsFolder).FirstOrDefault();
                if (matchingDir != null)
                {
                    return matchingDir;
                }
                foreach (var dir in dirs)
                {
                    var fetchedFolder = FindPaladinsFolder(dir);
                    if (fetchedFolder != null)
                    {
                        return fetchedFolder;
                    }
                }

            }
            catch { }

            return null;

        }
        public static bool IsPaladinsFolder(string path)
        {
            return Path.GetFileName(path).Equals("Paladins") &&
                File.Exists(path + "/ChaosGame/CookedPCConsole/Shootingrange_P.upk");
        }
        public static bool Restore(string gameFolderpath,string restoreFile)
        {
            try
            {
                var filePath = gameFolderpath + "/ChaosGame/CookedPCConsole/" + Path.GetFileName(restoreFile);
                File.Copy(restoreFile, filePath,true);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ChangeMap(string gameFolderpath, string mapFilename)
        {
            try
            {
                var mapFilePath = gameFolderpath + "\\ChaosGame\\CookedPCConsole\\" + Path.GetFileName(mapFilename);
                var trainingFilePath = gameFolderpath + "\\ChaosGame\\CookedPCConsole\\" + "Shootingrange_P.upk";
                File.Copy(mapFilePath, trainingFilePath,true);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
