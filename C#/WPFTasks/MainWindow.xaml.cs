using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached("Html", typeof(string), typeof(MainWindow), new FrameworkPropertyMetadata(OnHtmlChanged));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread number. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                Thread.Sleep(5000);
                MyButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Thread number. {Thread.CurrentThread.ManagedThreadId} owns Mybutton");

                    MyButton.Content = "Done";
                });
            });
        }

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "Html";
            Debug.WriteLine($"Thread number. {Thread.CurrentThread.ManagedThreadId}");

            await Task.Run(async () =>
            {
                Debug.WriteLine($"Thread number during await task {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                Thread.Sleep(5000);
                myHtml = html;
            });

            MyButton.Content = "Done";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null) webBrowser.NavigateToString(e.NewValue as string);
        }
    }
}
