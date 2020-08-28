#pragma once
#include <ompl\base\State.h>
#include <ompl\base\spaces\RealVectorStateSpace.h>
#include <ompl\base\samplers\DeterministicStateSampler.h>
#include <ompl\base\samplers\deterministic\HaltonSequence.h>

namespace ompl
{
    namespace base
    {
        class Determinism
        {
        public:
            static void setDeterministicStateSamplerAllocator(StateSpace* space, unsigned int dim)
            {
                space->setStateSamplerAllocator
                (
                    std::bind
                    (
                        &allocHalton,
                        std::placeholders::_1,
                        dim
                    )
                );
            }

            static StateSamplerPtr allocHalton(const StateSpace* space, unsigned int dim)
            {
                return std::make_shared<RealVectorDeterministicStateSampler>
                (
                    space, 
                    std::make_shared<HaltonSequence>(dim)
                );
            }

        };
    }
}