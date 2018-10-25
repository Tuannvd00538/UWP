using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UWP_ASM.Frames
{
    public sealed partial class SaveFile : Page
    {
        public SaveFile()
        {
            this.InitializeComponent();
        }

        private async void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var name = fileName.Text;
            var cont = content.Text;
            if (name == "")
            {
                fileName_Message.Text = "Name is empty!";
            }
            else
            {
                fileName_Message.Text = "";
            }
            if (cont == "")
            {
                content_Message.Text = "Content is empty!";
            }
            else
            {
                content_Message.Text = "";
            }
            if (name != "" && cont != "")
            {
                StorageFolder folder = ApplicationData.Current.LocalFolder;
                StorageFile file = await folder.CreateFileAsync(name, CreationCollisionOption.ReplaceExisting);
                await FileIO.WriteTextAsync(file, cont);

                ContentDialog saveFileSuccess = new ContentDialog()
                {
                    Title = "Save file success!",
                    CloseButtonText = "Ok"
                };

                await saveFileSuccess.ShowAsync();
            }
        }
    }
}
