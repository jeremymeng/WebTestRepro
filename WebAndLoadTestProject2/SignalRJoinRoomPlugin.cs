using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace iRel8.Service.WebTests.WebtestPlugins
{
    public class SignalRJoinRoomPlugin : WebTestRequestPlugin
    {
        public override async void PreRequest(object sender, PreRequestEventArgs e)
        {
            var baseUrl = "http://localhost:15935";

            var connection = new HubConnectionBuilder()
                .WithUrl($"{baseUrl}/chat")
                .Build();

            await connection.StartAsync();
        }
    }
}
