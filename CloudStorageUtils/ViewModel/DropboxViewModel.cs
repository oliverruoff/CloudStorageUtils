using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStorageUtils.ViewModel
{
    public class DropboxViewModel : ViewModelBase
    {

        private string dropboxApiKey;
        private string userName;
        private IEnumerable<global::Dropbox.Api.Files.Metadata> listedFiles;

        public IEnumerable<global::Dropbox.Api.Files.Metadata> ListedFiles
        {
            get { return listedFiles; }
            set
            {
                listedFiles = value;
                OnPropertyChanged();
            }
        }


        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged();
            }
        }


        public string DropboxApiKey
        {
            get { return dropboxApiKey; }
            set
            {
                dropboxApiKey = value;
                OnPropertyChanged();
            }
        }

    }
}
