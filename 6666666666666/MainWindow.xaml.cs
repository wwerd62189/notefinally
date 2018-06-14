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

namespace _6666666666666
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string File_Path = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void new_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
               TextArea.Text = "";   
        }

        private void open_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 產生開啟檔案視窗 SaveFileDialog 
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;

                TextArea.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
            }

        private void save_MouseDown(object sender, MouseButtonEventArgs e)
        { 
            if (File_Path == "")
            {
                
                Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();
                Nullable<bool> result = dig.ShowDialog();

                if (result == true)
                {
                    File_Path = dig.FileName;
                    System.IO.File.WriteAllText(File_Path, TextArea.Text);
                }

                Title = dig.SafeFileName;
            }
            else
            {
                
                System.IO.File.WriteAllText(File_Path, TextArea.Text);
            }
        }

        private void saveas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 產生開啟檔案視窗 SaveFileDialog 
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                System.IO.File.WriteAllText(File_Path, TextArea.Text);
            }
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            TextArea.FontSize = 15;
        }

        private void Rectangle_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            TextArea.FontSize = 22;
        }

        private void Rectangle_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            TextArea.FontSize = 35;
        }

        private void black_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.Background = Brushes.DimGray;
            TextArea.Foreground = Brushes.White;

        }

        private void white_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.Background = Brushes.White;
            TextArea.Foreground = Brushes.Black;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
