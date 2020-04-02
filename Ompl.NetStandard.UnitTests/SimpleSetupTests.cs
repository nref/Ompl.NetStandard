using NUnit.Framework;

namespace Ompl.NetStandard.UnitTests
{
    public class SimpleSetupTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Instantiates()
        {
            var space = new RealVectorStateSpace();
            var bounds = new RealVectorBounds(3);
            bounds.setLow(0, -3);
            bounds.setLow(0, 3);
            bounds.setLow(1, -3);
            bounds.setLow(1, 3);
            bounds.setLow(2, -3);
            bounds.setLow(2, 3);

            space.setBounds(bounds);
            space.sanityChecks();

            var setup = new SimpleSetup(bounds));
        }
    }
}