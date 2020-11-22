using System;
using System.IO;
using System.Windows;
using Windows.System.UserProfile;

namespace LockScreenTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using var stream = File.OpenRead("test.jpg");
            LockScreen.SetImageStreamAsync(stream.AsRandomAccessStream()).GetAwaiter().GetResult();
        }
    }
}
