using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Race.Contracts;

namespace Race.Client
{
    public class HostedGameServiceCallback : IHostedGameServiceCallback
    {
        public void OnRecieveChatMessage(string message)
        {
            throw new NotImplementedException();
        }
    }

    public class GameClient : DuplexClientBase<IHostedGameService>, IHostedGameService
    {
        public GameClient(IHostedGameServiceCallback callbackInstance)
            : base(callbackInstance)
        {
            
        }

        public void Join(string clientName, HostedGameInfo gameToJoin)
        {
            Channel.Join(clientName, gameToJoin);
        }

        public void Leave()
        {
            Channel.Leave();
        }

        public GameState GetGameState()
        {
            return Channel.GetGameState();
        }

        public void SendChatMessage(string message)
        {
            Channel.SendChatMessage(message);
        }
    }
}
