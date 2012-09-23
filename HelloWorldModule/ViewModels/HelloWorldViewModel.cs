using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;

namespace HelloWorldModule.ViewModels
{
    [Export(typeof(HelloWorldViewModel))]
    class HelloWorldViewModel : NotificationObject
    {
        private List<String> resources = new List<String>();

        [ImportingConstructor]
        public HelloWorldViewModel()
        {
            resources.Add("One");
            resources.Add("Two");
            resources.Add("Three");
        }

        public List<String> ResourceList
        {
            get {
                return resources;
            }
        }
    }
}
