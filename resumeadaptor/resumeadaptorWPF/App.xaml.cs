using resumeadaptorWPF.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace resumeadaptorWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static cv myCv { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            myCv = new cv();
            base.OnStartup(e);

            //Startup
            //Window main = new MainWindow();
            //main.Show();

            //Bind Commands
            //resumeadaptorWPF.Commands.BindCommandsToWindow(main);

            // Create runtime objects
            // Assign to accessible property.
            
        }

        //public static explicit operator App(Application v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
