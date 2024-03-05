using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VocaApp.UI.Views;

namespace VocaApp
{
    internal class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow();
            //throw new NotImplementedException();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //throw new NotImplementedException();
        }
    }
}
