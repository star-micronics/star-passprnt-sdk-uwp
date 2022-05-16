using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace PassPRNT_SDK_CS
{
    class AssetFolderManager
    {
        public static async Task<IList<string>> GetFileList(string type)
        {
            IList<string> fileList = new List<string>();

            StorageFolder appInstalledFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFolder assets = await appInstalledFolder.GetFolderAsync("Assets");

            IReadOnlyList<StorageFile> allfiles = await assets.GetFilesAsync();

            foreach (StorageFile file in allfiles)
            {
                if (String.Equals(file.FileType, "." + type, StringComparison.CurrentCultureIgnoreCase))
                {
                    MyDebug.Console(file.Name);
                    fileList.Add(file.Name);
                }
                else
                {
                    MyDebug.Console("false : " + file.Name);
                }
            }

            return fileList;
        }

        public static async Task<string> LoadFileData(string fileName)
        {
            StorageFolder appInstalledFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFolder assets = await appInstalledFolder.GetFolderAsync("Assets");

            try
            {
                StorageFile file = await assets.GetFileAsync(fileName);
                if (fileName.EndsWith("html"))
                {
                    return await FileIO.ReadTextAsync(file);
                }

                return "blank";
            }
            catch (FileNotFoundException e)
            {
                MyDebug.Console(e.Message);
                return "blank";
            }
            catch (ArgumentOutOfRangeException e)
            {
                MyDebug.Console(e.Message);
                return "blank";
            }
            catch (ArgumentNullException e)
            {
                return "blank";
            }
        }
    }
}
