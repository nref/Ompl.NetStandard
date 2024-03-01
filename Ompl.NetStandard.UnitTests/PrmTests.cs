using NUnit.Framework;
using Ompl.Base;
using Ompl.Geometric;

namespace Ompl.NetStandard.UnitTests
{
  public class PrmTests
  {
    [Test]
    public void TestPrm()
    {
      var prm = new PRM((SpaceInformation)null);
      var plannerData = new PlannerData(null);

      prm.getPlannerData(plannerData);
    }

    [Test]
    public void TestPRMstar()
    {
      var prm = new PRMstar((SpaceInformation)null);
      var plannerData = new PlannerData(null);

      prm.getPlannerData(plannerData);
    }
  }
}