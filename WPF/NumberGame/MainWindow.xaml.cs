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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    ///
    

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        static Random r = new Random();
        int a = r.Next(1, 25);


        private void Button_Click(object sender, RoutedEventArgs e) {
            
            Button bt = (Button)sender;
            if (a == int.Parse((string)bt.Content)) {
                textblock.Text = "正解";
                bt.Background = Brushes.Red;
            }
                
            if(a < int.Parse((string)bt.Content))
                textblock.Text = "もっと小さい";
            if (a > int.Parse((string)bt.Content))
                textblock.Text = "もっと大きい";
        }
    }
}
