using AA.Notify;

using FlutterSignalRClient.Models;

using System;

namespace FlutterSignalRClient.ViewModels
{
    public class BaseViewModel : NotifyPropertyChanged
    {
        public static UserModel User { get; set; } = 
            new UserModel() 
            {
                Santral = new SantralModel(new UretimOzetModel(0,0,0,0,0,0)),
            };

        public const String URL = "https://aosignalr.aliates.com/";
    }
}
