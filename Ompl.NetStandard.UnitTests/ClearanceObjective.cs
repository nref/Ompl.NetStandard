using Ompl.Base;

namespace Ompl.NetStandard.UnitTests
{
    public class ClearanceObjective : StateCostIntegralObjective
    {
        private readonly SpaceInformation _si;

        public ClearanceObjective(SpaceInformation si)
            : base(si, false)
        {
            _si = si;
        }

        public override Cost stateCost(State s)
        {
            return new Cost(1 / _si.getStateValidityChecker().clearance(s));
        }
    }
}