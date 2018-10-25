using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_ASM.Entity;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace UWP_ASM.Frames
{
    public sealed partial class ShowFile : Page
    {
        ObservableCollection<FileSave> files = new ObservableCollection<FileSave>();
        public ShowFile()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            IReadOnlyList<StorageFile> items = await ApplicationData.Current.LocalFolder.GetFilesAsync();
            foreach (StorageFile file in items)
            {
                FileSave files_ = new FileSave();
                files_.Name = file.Name;
                files_.Content = file.Name;
                files.Add(files_);
            }
        }
    }
}
