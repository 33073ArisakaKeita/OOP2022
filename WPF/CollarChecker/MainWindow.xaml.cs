using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
//色がおかしい。listboxの選択した値をスライダーや色に正しく反映したい

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>

    public partial class MainWindow : Window {

        MyColor mycolor = new MyColor();
        List<MyColor> ColorList = new List<MyColor>();

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList(); //←追加
            Enabled_Check();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor(0, 0, 0);
        }

        private void SampleSlider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var r = byte.Parse(textbox_R.Text);
            var g = byte.Parse(textbox_G.Text);
            var b = byte.Parse(textbox_B.Text);
            setColor(r, g, b);
        }

        private void textbox_R_KeyUp(object sender, KeyEventArgs e) {
            if (textbox_R == null || textbox_G == null || textbox_B == null ||
               textbox_R.Text == "" || textbox_G.Text == "" || textbox_B.Text == "" || color_label == null)
                return;
            var r = byte.Parse(textbox_R.Text);
            var g = byte.Parse(textbox_G.Text);
            var b = byte.Parse(textbox_B.Text);
            setColor(r, g, b);
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var color = (MyColor)((ComboBox)sender).SelectedItem;
            var color_r = color.Color.R;
            var color_g = color.Color.G;
            var color_b = color.Color.B;

            textbox_R.Text = color_r.ToString();
            textbox_G.Text = color_g.ToString();
            textbox_B.Text = color_b.ToString();

            color_label.Background = new SolidColorBrush(Color.FromRgb(color_r, color_g, color_b));

        }

        //private void textbox_R_PreviewTextInput(object sender, TextCompositionEventArgs e) {
        //    e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        //}

        //private void textbox_R_PreviewExecuted(object sender, ExecutedRoutedEventArgs e) {
        //    if (e.Command == ApplicationCommands.Paste)
        //        e.Handled = true;
        //}

        private void stock_button_Click(object sender, RoutedEventArgs e) {
           
            MyColor stColor = new MyColor();
            var r = byte.Parse(textbox_R.Text);
            var g = byte.Parse(textbox_G.Text);
            var b = byte.Parse(textbox_B.Text);
            stColor.Color = Color.FromRgb(r, g, b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R &&
                                            c.Color.G == stColor.Color.G &&
                                            c.Color.B == stColor.Color.B).FirstOrDefault();
            stock_colors.Items.Insert(0,colorName?.Name ?? "R:" + r + " G:" + g + " B:" + b);
            ColorList.Insert(0, stColor);
            Enabled_Check();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e) {
            if (stock_colors.SelectedItem != null) {
                stock_colors.Items.RemoveAt(stock_colors.SelectedIndex);
                ColorList.RemoveAt(stock_colors.SelectedIndex);
                Enabled_Check();
            }
        }

        private void Enabled_Check() {
            if (stock_colors.Items.Count != 0)
                Delete_Button.IsEnabled = true;
            else
                Delete_Button.IsEnabled = false;
        }

        private void stock_colors_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stock_colors.SelectedIndex >= 0) {
                SampleSlider_R.Value = ColorList[stock_colors.SelectedIndex].Color.R;
                SampleSlider_G.Value = ColorList[stock_colors.SelectedIndex].Color.G;
                SampleSlider_B.Value = ColorList[stock_colors.SelectedIndex].Color.B;
            }
        }

        private void setColor(byte r, byte g, byte b) {
            color_label.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}