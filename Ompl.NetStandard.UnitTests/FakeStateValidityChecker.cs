using Ompl.Base;

namespace Ompl.NetStandard.UnitTests
{
    public class FakeStateValidityChecker : StateValidityChecker
    {
        public FakeStateValidityChecker(SpaceInformation si) : base(si)
        {
        }

        public override bool isValid(State s) => true;

        public override double clearance(State s) => 1;
    }
}