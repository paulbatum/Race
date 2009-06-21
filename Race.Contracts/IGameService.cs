using System.ServiceModel;

namespace Race.Contracts
{
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        GameState GetGameState(string playerName);


    }

   
}