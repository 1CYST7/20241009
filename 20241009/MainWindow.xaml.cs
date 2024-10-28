using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _20241009
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 定義飲料及其價格的字典
        Dictionary<string, int> drinks = new Dictionary<string, int>
        {
            { "紅茶大杯", 60 },
            { "紅茶小杯", 40 },
            { "綠茶大杯", 50 },
            { "綠茶小杯", 30 },
            { "可樂大杯", 50 },
            { "可樂小杯", 30 },
            { "咖啡大杯", 80 },
            { "咖啡小杯", 50 }
        };
       
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var targetSlider = sender as Slider; // 取得觸發事件的滑桿
            int amount = (int)targetSlider.Value; // 取得滑桿的值並轉為整數，表示選擇的數量
            var targetStackPanel = targetSlider.Parent as StackPanel; // 取得滑桿的父容器 StackPanel
            var targetLabel = targetStackPanel.Children[0] as Label; // 第一個子元素是 Label，取出並作為飲料名稱的標籤
            var drinkName = targetLabel.Content.ToString(); // 取得標籤的內容，為飲料名稱

            // 顯示訊息框，內容包括飲料名稱、數量和總價
            MessageBox.Show(drinkName + " " + amount + "杯，共" + drinks[drinkName] * amount + "元");
        }

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var targetTextBox = sender as TextBox;

        //    //MessageBox.Show(targetTextBox.Text);
        //    int amount;
        //    bool success = int.TryParse(targetTextBox.Text, out amount);

        //    if (!success) MessageBox.Show("請輸入數字", "輸入錯誤");
        //    else if (amount <= 0) MessageBox.Show("請輸入正整數", "輸入錯誤");
        //    else
        //    {
        //        var targetStackPanel = targetTextBox.Parent as StackPanel;
        //        var targetLabel = targetStackPanel.Children[0] as Label;
        //        var drinkName = targetLabel.Content.ToString();

        //        MessageBox.Show(drinkName + " " + amount + "杯，共" + drinks[drinkName] * amount + "元");
        //    }
        //}
    }
}