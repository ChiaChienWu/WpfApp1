using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            media.Source = new Uri(@"E:\Wistron\VideoForTesting.mp4");
            // 互動式控制
            media.LoadedBehavior = MediaState.Manual;
            // 新增元素載入完成事件 -- 自動開始播放
            media.Loaded += new RoutedEventHandler(media_Loaded);
            //// 新增媒體播放結束事件 -- 重新播放
            //mediaElement.MediaEnded += new RoutedEventHandler(media_MediaEnded);
            //// 新增元素解除安裝完成事件 -- 停止播放
            //mediaElement.Unloaded += new RoutedEventHandler(media_Unloaded);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void media_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as MediaElement).Play();
        }
    }
    
}
