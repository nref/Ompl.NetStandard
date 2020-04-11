using Ompl.Base;

namespace Ompl.NetStandard.UnitTests
{

    public partial class SimpleSetupTests
    {
        public class FakeMotionValidator : MotionValidator
        {
            public FakeMotionValidator(SpaceInformation si) : base(si)
            {
            }

            public override bool checkMotion(State s1, State s2)
            {
                return true;
            }

            public override bool checkMotion(State s1, State s2, SWIGTYPE_p_std__pairT_ompl__base__State_p_double_t lastValid)
            {
                return true;
            }
        }
    }
}