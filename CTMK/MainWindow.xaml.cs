using CTMK_API.Utility;
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

namespace CTMK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(OnKeyUp);
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            var key = "";
            if (e.Key == Key.System)
            {
                key = e.SystemKey.ToString();
            }
            else
            {
                key = e.Key.ToString();
            }
            test.Content = key;
            try
            {
                Console.WriteLine(ButtonUtil.KeyToVirtualKey(key));
            }
            catch (Exception)
            {
                Console.WriteLine(key + " not supported yet");
            }
            
            //Console.WriteLine(key);

            /*using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\dev\test\textFiles\keyboard.txt",true))
            {
                file.WriteLine(key);
            }*/
        }
    }
}
