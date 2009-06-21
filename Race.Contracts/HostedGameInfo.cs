using System.Runtime.Serialization;

namespace Race.Contracts
{
    [DataContract]
    public class HostedGameInfo
    {
        [DataMember] 
        public string GameName { get; set; }
    }

}