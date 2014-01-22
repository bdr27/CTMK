using CTMK_API.Control;
using CTMK_API.Control.Type;
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
        private GetControllers controller;
        private List<IController> avaliableControllers;
        private IController control;
        private bool DEBUG = true;
        public App(): base()
        {
            controller = new GetControllers();
            window = new MainWindow();
            if (DEBUG)
            {
                ConsoleManager.Show();
            }
            LoadControllers();
            UpdateController();
            window.Show();
        }

        private void UpdateAvaliableControls()
        {
            controller.Execute();            
        }

        private void UpdateController()
        {
            if (GetController(window.GetSelectedIndex()))
            {
                window.UpdateControllerDisplay(control);
            }
            else
            {
                LoadControllers();
            }
        }

        private void LoadControllers()
        {
            UpdateAvaliableControls();
            UpdateControllerSelection(controller.GetAvaliableControllers());
            avaliableControllers = controller.ConnectedControllers();
        }

        private bool GetController(int index)
        {
            try
            {
                control = controller.GetControl(index);
                if (control.GetName() == avaliableControllers[index].GetName())
                {
                    return true;
                }
            }
            catch
            {
                
            }
            return false;
        }

        private void UpdateControllerSelection(Dictionary<int, string> controls)
        {
            window.UpdateControllerDialog(controls);
        }

        private void WireHandlers()
        {
            window.AddControllerSelectionHandler(HandleControllerChange_Select);
        }

        private void HandleControllerChange_Select(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            UpdateController();
        }
    }
}
