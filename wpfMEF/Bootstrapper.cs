using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions;
using System.ComponentModel.Composition.Hosting;
using HelloWorldModule;

namespace wpftest
{
    class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

#if SILVERLIGHT
            Application.Current.RootVisual = (Shell)this.Shell;            
#else
            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
#endif

         }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(
                new AssemblyCatalog(typeof(HelloWorldModule.HelloWorldModule).Assembly));
         
        }
    }
}
