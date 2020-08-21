using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NavViewWinUI2._4._2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<CustomMenuItem> Headers { get; set; }
        public MainPage()
        {
            CreateHeaders();
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void CreateHeaders()
        {
            Headers = new ObservableCollection<CustomMenuItem>();
            Headers.Add(new CustomMenuItem { HeaderTitle = "Header" });
            Headers.Add(new CustomMenuItem { HeaderTitle = "Header" });
            Headers.Add(new CustomMenuItem { HeaderTitle = "Header" });
            Headers.Add(new CustomMenuItem { HeaderTitle = "Header" });

        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            nvMenu.UpdateLayout();
            nvMenu.SelectedItem = Headers.FirstOrDefault();
        }
    }
}
