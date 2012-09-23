using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace HelloWorldModule 
{
    public class HelloWorldModule : IModule
    {
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
