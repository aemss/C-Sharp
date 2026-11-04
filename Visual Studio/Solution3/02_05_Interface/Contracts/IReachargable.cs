
namespace Contracts;
public interface IReachargable 
{
    //yapısal
    int BatteryLevel { get; }


    // davranışsal

    void Recharge(int amount);

}



