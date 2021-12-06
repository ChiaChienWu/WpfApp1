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
        double dtemp = 1;//宣告放大縮小時暫存變數
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            media.Source = new Uri(@"E:\Wistron\VideoForTesting.mp4");//宣告讀取路徑
            //互動式控制
            media.LoadedBehavior = MediaState.Manual;
            //新增元素載入完成事件自動開始播放
            media.Loaded += new RoutedEventHandler(media_Loaded);
        }


        private void media_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as MediaElement).Play();//執行播放
        }

        private void btnBig_Click(object sender, RoutedEventArgs e)//放大元素
        {
            if (dtemp <= 2.5)//設定最大值
            {
                dtemp += 0.1;//放大10%
                media.RenderTransform = new ScaleTransform(dtemp, dtemp, 0.5, 0.5);//設定frame元素大小及中心點
            }
            else
                MessageBox.Show("已達最大值!最大值:" + dtemp * 100 + "%");

        }

        private void btnsmall_Click(object sender, RoutedEventArgs e)//縮小元素
        {
            if (dtemp > 0.1)//設定最小值
            {
                media.RenderTransform = new ScaleTransform(dtemp - 0.1, dtemp - 0.1, 0.5, 0.5);//設定frame元素大小及中心點
                dtemp -= 0.1;//縮小10%
            }
            else
                MessageBox.Show("已達最小值!最小值:" + 0 * 100 + "%");
                
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
