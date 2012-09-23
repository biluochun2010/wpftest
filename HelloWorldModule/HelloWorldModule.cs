using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.MefExtensions.Modularity;

namespace HelloWorldModule 
{
    [ModuleExport(typeof(HelloWorldModule))]
    public class HelloWorldModule : IModule
    {
        [ImportingConstructor]
        public HelloWorldModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        private readonly IRegionManager regionManager;

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloWorldView));
        }
    }
}
