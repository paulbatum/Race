using System;
using System.Linq;
using System.ServiceModel;
using Race.Contracts;

namespace Race.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class HostedGameService : IHostedGameService
    {
        private Client _client;
        private HostedGame _game;

        public void Join(string clientName, HostedGameInfo gameToJoin)
        {
            _client = ClientList.Current.Single(c => c.Name == clientName);
            _game = GameList.Current.Single(g => g.Name == gameToJoin.GameName);

            var callback = OperationContext.Current.GetCallbackChannel<IHostedGameServiceCallback>();
            _game.AddClient(_client, callback);
        }

        public void Leave()
        {
            throw new NotImplementedException();
        }

        public GameState GetGameState()
        {
            throw new NotImplementedException();
        }

        public void SendChatMessage(string message)
        {
            _game.SendChatMessageToAllPlayers(_client, message);
        }
    }
}