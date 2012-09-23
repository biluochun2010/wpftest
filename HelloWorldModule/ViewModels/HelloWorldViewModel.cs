using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Events;

namespace HelloWorldModule.ViewModels
{
    [Export(typeof(HelloWorldViewModel))]
    public class HelloWorldViewModel : NotificationObject
    {
        private List<Resource> resources = new List<Resource>();
        private Resource currentResource;
        private readonly IEventAggregator eventAggregator;

        [ImportingConstructor]
        public HelloWorldViewModel(IEventAggregator eventAggregator)
        {
            resources.Add(new Resource { Title = "title1", Urn = "urn:urn1" });
            resources.Add(new Resource { Title = "title2", Urn = "urn:urn2" });
            this.eventAggregator = eventAggregator;
        }

        public List<Resource> ResourceList
        {
            get {
                return resources;
            }
        }

        public Resource CurrentResource
        {
            get { return currentResource; }
            set
            {
                if (currentResource != value)
                {
                    currentResource = value;
                    RaisePropertyChanged(() => CurrentResource);
                   
                }
            }
        }
    }
}
