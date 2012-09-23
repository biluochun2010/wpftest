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
        private List<Resource> resources = new List<Resource>();

        [ImportingConstructor]
        public HelloWorldViewModel()
        {
            resources.Add(new Resource { Title = "title1", Urn = "urn:urn1" });
            resources.Add(new Resource { Title = "title2", Urn = "urn:urn2" });
        }

        public List<Resource> ResourceList
        {
            get {
                return resources;
            }
        }
    }
}
