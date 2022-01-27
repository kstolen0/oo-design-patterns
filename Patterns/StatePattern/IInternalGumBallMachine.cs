using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Patterns.StatePattern
{
    internal interface IInternalGumBallMachine : IGumBallStateManager, IGumBallMachine
    {
        void Dispense();

        int GetGumBallCount();

        void ReleaseBall();

        void AddGumBalls(int gumballs);


    }
}
