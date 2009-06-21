using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Race.Contracts;
using Race.Domain;
using Player=Race.Domain.Player;

namespace Race.Server
{
    public class Client
    {
        public string Name { get; private set; }

        public Client(string name)
        {
            Name = name;
        }
    }

    public class ClientList : List<Client>
    {
        public static ClientList Current = new ClientList();
    }

    public class HostedGame
    {
        private Game _game;
        private IDictionary<Player, Client> _players;
        private IDictionary<Client, IHostedGameServiceCallback> _callbacks;

        public string Name { get; private set; }

        public HostedGame(string name)
        {
            Name = name;
        }

        public void SendChatMessageToAllPlayers(Client originator, string message)
        {
            foreach (var callback in _callbacks.Values)
                callback.OnRecieveChatMessage(string.Format("{0}: {1}", originator.Name, message));
        }

        public void AddClient(Client client, IHostedGameServiceCallback callback)
        {
            var player = new Player { Name = client.Name };
            _players[player] = client;
            _callbacks[client] = callback;
        }
    }

    public class GameList : List<HostedGame>
    {
        public static GameList Current = new GameList();
    }
}
