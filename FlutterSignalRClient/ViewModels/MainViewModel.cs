using AA.Notify;

using FlutterSignalRClient.Models;

using Microsoft.AspNetCore.SignalR.Client;

using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlutterSignalRClient.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private HubConnection santralConnection;

        public ICommand UretimOzetSendCommand { get; set; }

        private UretimOzetModel uretimOzet;
        public UretimOzetModel UretimOzet { get => uretimOzet; set => SetProperty(ref uretimOzet, value); }


        public MainViewModel()
        {
            UretimOzet = new UretimOzetModel();
            BuildCommands();

            //santralConnection = new HubConnectionBuilder().WithUrl(URL + "santral", options =>
            //{
            //    options.AccessTokenProvider = () => Task.FromResult(User.Token.AccessToken);
            //}).Build();

            santralConnection = new HubConnectionBuilder().WithUrl(URL + "santral").Build();

            santralConnection.On<UretimOzetModel>("UretimOzet", (uretimOzet) =>
            {
                User.Santral.UretimOzet = uretimOzet;
            });

            santralConnection.StartAsync();
        }

        private void BuildCommands()
        {
            UretimOzetSendCommand = new Command(async () =>
            {
                await santralConnection.InvokeAsync("UretimOzetAsync", UretimOzet);
            });
        }
    }
}
