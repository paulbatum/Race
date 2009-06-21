using System.ServiceModel;
namespace Race.Contracts
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IRaceServer
    {
        [OperationContract(IsInitiating = true)]
        void Connect(string playerName);

        [OperationContract(IsInitiating = false, IsTerminating = true)]
        void Disconnect();

        [OperationContract(IsInitiating = false)]
        HostedGameInfo[] GetOpenGames();
    }
}