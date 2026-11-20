using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WinUI_Wallpaper.Pages;

namespace WinUI_Wallpaper
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);
            AppWindow.TitleBar.PreferredHeightOption = TitleBarHeightOption.Tall;
            AppWindow.SetIcon("Assets/app.ico");
        }

        private void TitleBar_PaneToggleRequested(TitleBar sender, object args)
        {
            NavView.IsPaneOpen = !NavView.IsPaneOpen;
        }

        private void TitleBar_BackRequested(TitleBar sender, object args)
        {
            NavFrame.GoBack();
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                NavFrame.Navigate(typeof(SettingsPage));
            }
            else if (args.SelectedItem is NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "home":
                        NavFrame.Navigate(typeof(HomePage));
                        break;
                    case "about":
                        NavFrame.Navigate(typeof(AboutPage));
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown navigation item tag: {item.Tag}");
                }
            }
        }
    }
}
