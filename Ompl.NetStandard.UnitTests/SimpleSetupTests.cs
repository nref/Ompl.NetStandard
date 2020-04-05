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
            var space = new Base.RealVectorStateSpace(3);
            var bounds = new Base.RealVectorBounds(3);
            bounds.setLow(0, -3);
            bounds.setHigh(0, 3);
            bounds.setLow(1, -3);
            bounds.setHigh(1, 3);
            bounds.setLow(2, -3);
            bounds.setHigh(2, 3);

            space.setBounds(bounds);
            space.sanityChecks();

            var ss = new Geometric.SimpleSetup(space);
            var pd = ss.getProblemDefinition();
            var si = ss.getSpaceInformation();
            var planner = new Geometric.KPIECE1(si);
            ss.setPlanner(planner);
            space.setup();

            // TODO
            //var start = new Base.ScopedState(space);
            //var goal = new Base.ScopedState(space);
            //space.copyFromReals(start, ...);
            //space.copyFromReals(goal, ...);

            //pd.setStartAndGoalStates(start, goal);
            var objective = new Base.MultiOptimizationObjective(si);
            //var clearanceObjective = new Base.OptimizationObjective(new ClearanceObjective(si));
            //objective.addObjective(clearanceObjective);
            pd.setOptimizationObjective(objective);
            //si.setValidStateSamplerAllocator();
            si.allocValidStateSampler();
            si.setStateValidityCheckingResolution(0.01);
            ss.solve(1);

            var solution = ss.getSolutionPath();
            var simplifier = ss.getPathSimplifier();

            simplifier.reduceVertices(solution);
            simplifier.smoothBSpline(solution, 3);
        }
    }
}