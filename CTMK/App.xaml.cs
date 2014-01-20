using CTMK.Debugger;
using CTMK_API.Control;
using CTMK_API.Controller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CTMK
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private bool DEBUG = true;
        public App(): base()
        {
            if (DEBUG)
            {
                ConsoleManager.Show();
            }
            var run = new GetControllers();
            run.Execute();
            var controllers = run.ConnectedControllers();

            ControllerTemplate ct = new MOCKController(controllers[0]);
            ct.Run();
        }
    }
}
