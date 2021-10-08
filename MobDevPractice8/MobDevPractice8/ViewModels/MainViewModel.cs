using MobDevPractice8.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MobDevPractice8.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
        public DeviceOrientation orientation { get; set; }
        public string Orientation { get; set; }
        public MainViewModel()
        {
            DeviceOrientation orientation = service.GetOrientation();
            Orientation = orientation.ToString();
        }
    }
}
