using CTMK_API.Control;
using CTMK_API.Debugger;
using System.Collections.Generic;
using System.Windows;

namespace CTMK
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow window;
        private bool DEBUG = true;
        public App(): base()
        {
            window = new MainWindow();
            if (DEBUG)
            {
                ConsoleManager.Show();
            }
            var run = new GetControllers();
            run.Execute();
            UpdateControllerDialog(run.GetAvaliableControllers());
            window.Show();
        }

        private void UpdateControllerDialog(Dictionary<int, string> controls)
        {
            window.UpdateControllerDialog(controls);
        }
    }
}
