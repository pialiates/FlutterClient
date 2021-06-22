using AA.Notify;

using FlutterSignalRClient.Models;
using FlutterSignalRClient.Views;

using Microsoft.AspNetCore.SignalR.Client;

using System;
using System.Windows.Input;

namespace FlutterSignalRClient.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        HubConnection loginConnection;

        public LoginViewModel()
        {
            loginConnection = new HubConnectionBuilder().WithUrl(URL + "login")
                                                    .Build();

            BuildEvents();

            loginConnection.StartAsync();
        }

        private void BuildEvents()
        {
            LoginCommand = new Command(async () =>
            {
                var user = await loginConnection.InvokeAsync<UserModel>("Login", User.Username, User.Password);

                if (user != null)
                {
                    User.Id = user.Id;
                    User.Santral = user.Santral;
                    User.Token = user.Token;

                    App.Current.Dispatcher.Invoke(() =>
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.ShowDialog();
                    });

                    
                }
            });
        }
    }
}
