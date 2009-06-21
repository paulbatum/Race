using System.ServiceModel;

namespace Race.Contracts
{
    [ServiceContract(
        SessionMode = SessionMode.Required, 
        CallbackContract = typeof(IHostedGameServiceCallback)        
        )]
    public interface IHostedGameService
    {
        [OperationContract(IsInitiating = true)]
        void Join(string clientName, HostedGameInfo gameToJoin);

        [OperationContract(IsInitiating = false, IsTerminating = true)]
        void Leave();

        [OperationContract(IsInitiating = false)]
        GameState GetGameState();

        [OperationContract(IsInitiating = false)]
        void SendChatMessage(string message);
    }


    public interface IHostedGameServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnRecieveChatMessage(string message);
    }
   
}