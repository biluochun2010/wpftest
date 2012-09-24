using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Events;
using Commons;

namespace wpftest.ViewModels
{
    [Export(typeof(ShellViewModel))]
    
    public class ShellViewModel:NotificationObject
    {

        private readonly IEventAggregator eventAggregator;
        private string title;

        [ImportingConstructor]
        public ShellViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            title = "Hello Shell Event";
            eventAggregator.GetEvent<TitleChangedEvent>().Subscribe(ChangeTitle);
        }
   
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    RaisePropertyChanged(() => Title);
                }
            }
        }

        private void ChangeTitle(string title)
        {
            Title = title;
        }

    }
}
