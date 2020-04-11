using NUnit.Framework;
using Ompl.Base;
using System;
using System.Collections.Generic;

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

    public partial class SimpleSetupTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Instantiates()
        {
            var bounds = new RealVectorBounds(3);
            bounds.setLow(0, -3);
            bounds.setHigh(0, 3);
            bounds.setLow(1, -3);
            bounds.setHigh(1, 3);
            bounds.setLow(2, -3);
            bounds.setHigh(2, 3);

            var space = new RealVectorStateSpace(3);
            space.setBounds(bounds);
            space.sanityChecks();

            var ss = new Geometric.SimpleSetup(space);
            var si = ss.getSpaceInformation();
            si.setMotionValidator(new FakeMotionValidator(si));
            space.setup();

            var start = new ScopedStateRealVectorStateSpace(space);
            var goal = new ScopedStateRealVectorStateSpace(space);
            space.copyFromReals(start.get(), new doubleVector(new List<double> { 1, 2, 3 }));
            space.copyFromReals(goal.get(), new doubleVector(new List<double> { 4, 5, 6 }));

            var pd = ss.getProblemDefinition();
            pd.setStartAndGoalStates(start.get(), goal.get());

            var objective = new MultiOptimizationObjective(si);
            objective.addObjective(new ClearanceObjective(si), 1);
            objective.addObjective(new PathLengthOptimizationObjective(si), 1);
            pd.setOptimizationObjective(objective);
            
            si.setValidStateSamplerAllocator(new ValidStateSamplerAllocator(si_ => new UniformValidStateSampler(si_)));
            si.allocValidStateSampler();
            si.setStateValidityCheckingResolution(0.01);

            var planner = new Geometric.KPIECE1(si);
            ss.setPlanner(planner);

            while (!ss.haveExactSolutionPath())
            {
                ss.solve(1);
            }

            //ss.simplifySolution();
            var solution = ss.getSolutionPath();
            var simplifier = ss.getPathSimplifier();

            simplifier.reduceVertices(solution);
            simplifier.smoothBSpline(solution, 3);

        }
    }
}