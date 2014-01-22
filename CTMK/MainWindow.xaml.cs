using CTMK_API.Control.Type;
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
            BindDictionary(cmbControls);            
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
            try
            {
                Console.WriteLine(ButtonUtil.KeyToVirtualKey(key));
            }
            catch (Exception)
            {
                Console.WriteLine(key + " not supported yet");
            }
        }

        public void UpdateControllerDialog(Dictionary<int, string> controls)
        {
            cmbControls.ItemsSource = controls;
            cmbControls.SelectedIndex = 0;
        }

        private void BindDictionary(ComboBox control)
        {
            control.SelectedValuePath = "Key";
            control.DisplayMemberPath = "Value";
        }

        public int GetSelectedIndex()
        {
            return (int)cmbControls.SelectedValue;
        }

        public void UpdateControllerDisplay(IController control)
        {
            
        }

        //Move this to cn
        public void AddControllerSelectionHandler(SelectionChangedEventHandler handler)
        {
            cmbControls.SelectionChanged += handler;
        }
    }
}
