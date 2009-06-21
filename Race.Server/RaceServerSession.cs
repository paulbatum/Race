using System.Collections.Generic;
using System.Text;
using Race.Contracts;
using System.ServiceModel;
using System.Linq;

namespace Race.Server
{
    [ServiceBehavior( InstanceContextMode = InstanceContextMode.PerSession )]
    public class RaceServerSession : IRaceServer
    {
        private Client _client;

        public void Connect(string clientName)
        {
            _client = new Client(clientName);
            ClientList.Current.Add(_client);
        }

        public void Disconnect()
        {
            ClientList.Current.Remove(_client);
            _client = null;
        }

        public HostedGameInfo[] GetOpenGames()
        {
            return GameList.Current.Select(g => new HostedGameInfo { GameName = g.Name}).ToArray();
        }
    }
}
