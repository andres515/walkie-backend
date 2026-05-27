using Microsoft.AspNetCore.SignalR;

namespace WalkieBackend.Hubs
{
    public class AudioHub : Hub
    {
        public async Task SendAudio(string audioBase64)
        {
            await Clients.Others.SendAsync("ReceiveAudio", audioBase64);
        }

        public async Task UserTalking(bool talking)
        {
            await Clients.Others.SendAsync("UserTalking", talking);
        }
    }
}