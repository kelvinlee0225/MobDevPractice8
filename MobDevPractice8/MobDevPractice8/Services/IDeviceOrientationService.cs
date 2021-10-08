using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace MobDevPractice8.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
