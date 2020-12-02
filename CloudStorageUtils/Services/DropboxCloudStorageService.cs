using Dropbox.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStorageUtils.ViewModel
{
    public class DropboxCloudStorageService : ViewModelBase
    {

        public string DropboxApiKey { get; set; }
        public DropboxClient DropboxClient { get; set; }

        public DropboxCloudStorageService(string dropboxApiKey)
        {
            DropboxApiKey = dropboxApiKey;
            DropboxClient = new DropboxClient(dropboxApiKey);
        }

        public async Task<string> GetUserName()
        {
            var fullAccount = await DropboxClient.Users.GetCurrentAccountAsync();
            return fullAccount.Name.DisplayName;
        }

        public async Task<IEnumerable<global::Dropbox.Api.Files.Metadata>> ListCloudFolder(string folderPrefix)
        {
            var result = await DropboxClient.Files.ListFolderAsync(folderPrefix);
            var list = result.Entries.ToList();

            // var folderList = list.Entries.Where(i => i.IsFolder).ToList();
            // var fileList = list.Entries.Where(i => i.IsFile).ToList();

            // Console.WriteLine("Files found: {0}", fileList.Count.ToString());

            //foreach (var item in fileList)
            //{
            //    Console.WriteLine("File: {0} - {1}", item.Name, item.PathLower);
            //}

            return list;
        }
    }
}
