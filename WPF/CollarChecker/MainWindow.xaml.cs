using System;
using System.Collections.Generic;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList(); //←追加

        }

        private void SampleSlider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Null_Check();
            color_label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(textbox_R.Text), (byte)int.Parse(textbox_G.Text), (byte)int.Parse(textbox_B.Text)));
        }

        private void textbox_R_KeyUp(object sender, KeyEventArgs e) {
            Null_Check();
            color_label.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(textbox_R.Text), (byte)int.Parse(textbox_G.Text), (byte)int.Parse(textbox_B.Text)));

        }
        private void Null_Check() {
            if (String.IsNullOrEmpty(textbox_R.Text))
                textbox_R.Text = "0";
            if (String.IsNullOrEmpty(textbox_G.Text))
                textbox_G.Text = "0";
            if (String.IsNullOrEmpty(textbox_B.Text))
                textbox_B.Text = "0";
        }
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            SampleSlider_R.Value = color.R;
            SampleSlider_G.Value = color.G;
            SampleSlider_B.Value = color.B;
            color_label.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));

        }

        private void textbox_R_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void textbox_R_PreviewExecuted(object sender, ExecutedRoutedEventArgs e) {
            if (e.Command == ApplicationCommands.Paste)
                e.Handled = true;
        }
    }
}
