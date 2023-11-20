using BorderlessEntryInLibrary7.Handlers;

namespace BorderlessEntryInLibrary7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
            {
                if (view is BorderlessEntry)
                {
#if ANDROID
                    handler.PlatformView.Background = null;
                    handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    handler.PlatformView.SetPadding(15, 15, 15, 15);
#elif IOS
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
                    handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                    handler.PlatformView.FontWeight = Microsoft.UI.Text.FontWeights.Thin;
#endif
                }
            });

            MainPage = new AppShell();
        }
    }
}
