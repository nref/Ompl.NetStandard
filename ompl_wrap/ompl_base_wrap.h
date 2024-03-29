/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (https://www.swig.org).
 * Version 4.2.0
 *
 * Do not make changes to this file unless you know what you are doing - modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_ompl_base_WRAP_H_
#define SWIG_ompl_base_WRAP_H_

class SwigDirector_StateValidityChecker : public ompl::base::StateValidityChecker, public Swig::Director {

public:
    SwigDirector_StateValidityChecker(ompl::base::SpaceInformation *si);
    SwigDirector_StateValidityChecker(ompl::base::SpaceInformationPtr const &si);
    virtual ~SwigDirector_StateValidityChecker();
    virtual bool isValid(ompl::base::State const *state) const;
    virtual bool isValid(ompl::base::State const *state,double &dist) const;
    virtual bool isValid(ompl::base::State const *state,double &dist,ompl::base::State *validState,bool &validStateAvailable) const;
    virtual double clearance(ompl::base::State const *arg0) const;
    virtual double clearance(ompl::base::State const *state,ompl::base::State *arg1,bool &validStateAvailable) const;
    virtual bool operator ==(ompl::base::StateValidityChecker const &arg0) const;

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback2_t)(void *, void *, void *, void *);
    typedef double (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef double (SWIGSTDCALL* SWIG_Callback4_t)(void *, void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback5_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackisValid__SWIG_0, SWIG_Callback1_t callbackisValid__SWIG_1, SWIG_Callback2_t callbackisValid__SWIG_2, SWIG_Callback3_t callbackclearance__SWIG_0, SWIG_Callback4_t callbackclearance__SWIG_1, SWIG_Callback5_t callbackequal_to);

private:
    SWIG_Callback0_t swig_callbackisValid__SWIG_0;
    SWIG_Callback1_t swig_callbackisValid__SWIG_1;
    SWIG_Callback2_t swig_callbackisValid__SWIG_2;
    SWIG_Callback3_t swig_callbackclearance__SWIG_0;
    SWIG_Callback4_t swig_callbackclearance__SWIG_1;
    SWIG_Callback5_t swig_callbackequal_to;
    void swig_init_callbacks();
};

class SwigDirector_ValidStateSampler : public ompl::base::ValidStateSampler, public Swig::Director {

public:
    SwigDirector_ValidStateSampler(ompl::base::SpaceInformation const *si);
    virtual ~SwigDirector_ValidStateSampler();
    virtual bool sample(ompl::base::State *state);
    virtual bool sampleNear(ompl::base::State *state,ompl::base::State const *near,double distance);

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *, double);
    void swig_connect_director(SWIG_Callback0_t callbacksample, SWIG_Callback1_t callbacksampleNear);

private:
    SWIG_Callback0_t swig_callbacksample;
    SWIG_Callback1_t swig_callbacksampleNear;
    void swig_init_callbacks();
};

class SwigDirector_MotionValidator : public ompl::base::MotionValidator, public Swig::Director {

public:
    SwigDirector_MotionValidator(ompl::base::SpaceInformation *si);
    SwigDirector_MotionValidator(ompl::base::SpaceInformationPtr const &si);
    virtual ~SwigDirector_MotionValidator();
    virtual bool checkMotion(ompl::base::State const *s1,ompl::base::State const *s2) const;
    virtual bool checkMotion(ompl::base::State const *s1,ompl::base::State const *s2,std::pair< ompl::base::State *,double > &lastValid) const;

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *, void *);
    void swig_connect_director(SWIG_Callback0_t callbackcheckMotion__SWIG_0, SWIG_Callback1_t callbackcheckMotion__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackcheckMotion__SWIG_0;
    SWIG_Callback1_t swig_callbackcheckMotion__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_OptimizationObjective : public ompl::base::OptimizationObjective, public Swig::Director {

public:
    SwigDirector_OptimizationObjective(ompl::base::SpaceInformationPtr si);
    virtual ~SwigDirector_OptimizationObjective();
    virtual bool isSatisfied(ompl::base::Cost c) const;
    virtual bool isCostBetterThan(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual bool isCostEquivalentTo(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual bool isFinite(ompl::base::Cost cost) const;
    virtual ompl::base::Cost betterCost(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual ompl::base::Cost stateCost(ompl::base::State const *s) const;
    virtual ompl::base::Cost motionCost(ompl::base::State const *s1,ompl::base::State const *s2) const;
    virtual ompl::base::Cost combineCosts(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual ompl::base::Cost identityCost() const;
    virtual ompl::base::Cost infiniteCost() const;
    virtual ompl::base::Cost initialCost(ompl::base::State const *s) const;
    virtual ompl::base::Cost terminalCost(ompl::base::State const *s) const;
    virtual bool isSymmetric() const;
    virtual ompl::base::Cost averageStateCost(unsigned int numStates) const;
    virtual ompl::base::Cost motionCostHeuristic(ompl::base::State const *s1,ompl::base::State const *s2) const;
    virtual ompl::base::InformedSamplerPtr allocInformedStateSampler(ompl::base::ProblemDefinitionPtr const &probDefn,unsigned int maxNumberCalls) const;
    virtual void print(std::ostream &out) const;

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback2_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback4_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback5_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback6_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback7_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback8_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback9_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback10_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback11_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback12_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback13_t)(unsigned int);
    typedef void * (SWIGSTDCALL* SWIG_Callback14_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback15_t)(void *, unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback16_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackisSatisfied, SWIG_Callback1_t callbackisCostBetterThan, SWIG_Callback2_t callbackisCostEquivalentTo, SWIG_Callback3_t callbackisFinite, SWIG_Callback4_t callbackbetterCost, SWIG_Callback5_t callbackstateCost, SWIG_Callback6_t callbackmotionCost, SWIG_Callback7_t callbackcombineCosts, SWIG_Callback8_t callbackidentityCost, SWIG_Callback9_t callbackinfiniteCost, SWIG_Callback10_t callbackinitialCost, SWIG_Callback11_t callbackterminalCost, SWIG_Callback12_t callbackisSymmetric, SWIG_Callback13_t callbackaverageStateCost, SWIG_Callback14_t callbackmotionCostHeuristic, SWIG_Callback15_t callbackallocInformedStateSampler, SWIG_Callback16_t callback_print);

private:
    SWIG_Callback0_t swig_callbackisSatisfied;
    SWIG_Callback1_t swig_callbackisCostBetterThan;
    SWIG_Callback2_t swig_callbackisCostEquivalentTo;
    SWIG_Callback3_t swig_callbackisFinite;
    SWIG_Callback4_t swig_callbackbetterCost;
    SWIG_Callback5_t swig_callbackstateCost;
    SWIG_Callback6_t swig_callbackmotionCost;
    SWIG_Callback7_t swig_callbackcombineCosts;
    SWIG_Callback8_t swig_callbackidentityCost;
    SWIG_Callback9_t swig_callbackinfiniteCost;
    SWIG_Callback10_t swig_callbackinitialCost;
    SWIG_Callback11_t swig_callbackterminalCost;
    SWIG_Callback12_t swig_callbackisSymmetric;
    SWIG_Callback13_t swig_callbackaverageStateCost;
    SWIG_Callback14_t swig_callbackmotionCostHeuristic;
    SWIG_Callback15_t swig_callbackallocInformedStateSampler;
    SWIG_Callback16_t swig_callback_print;
    void swig_init_callbacks();
};

class SwigDirector_StateCostIntegralObjective : public ompl::base::StateCostIntegralObjective, public Swig::Director {

public:
    SwigDirector_StateCostIntegralObjective(ompl::base::SpaceInformationPtr const &si,bool enableMotionCostInterpolation=false);
    virtual ~SwigDirector_StateCostIntegralObjective();
    virtual bool isSatisfied(ompl::base::Cost c) const;
    virtual bool isCostBetterThan(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual bool isCostEquivalentTo(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual bool isFinite(ompl::base::Cost cost) const;
    virtual ompl::base::Cost betterCost(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual ompl::base::Cost stateCost(ompl::base::State const *s) const;
    virtual ompl::base::Cost motionCost(ompl::base::State const *s1,ompl::base::State const *s2) const;
    virtual ompl::base::Cost combineCosts(ompl::base::Cost c1,ompl::base::Cost c2) const;
    virtual ompl::base::Cost identityCost() const;
    virtual ompl::base::Cost infiniteCost() const;
    virtual ompl::base::Cost initialCost(ompl::base::State const *s) const;
    virtual ompl::base::Cost terminalCost(ompl::base::State const *s) const;
    virtual bool isSymmetric() const;
    virtual ompl::base::Cost averageStateCost(unsigned int numStates) const;
    virtual ompl::base::Cost motionCostHeuristic(ompl::base::State const *s1,ompl::base::State const *s2) const;
    virtual ompl::base::InformedSamplerPtr allocInformedStateSampler(ompl::base::ProblemDefinitionPtr const &probDefn,unsigned int maxNumberCalls) const;
    virtual void print(std::ostream &out) const;

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback2_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback4_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback5_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback6_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback7_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback8_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback9_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback10_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback11_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback12_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback13_t)(unsigned int);
    typedef void * (SWIGSTDCALL* SWIG_Callback14_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback15_t)(void *, unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback16_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackisSatisfied, SWIG_Callback1_t callbackisCostBetterThan, SWIG_Callback2_t callbackisCostEquivalentTo, SWIG_Callback3_t callbackisFinite, SWIG_Callback4_t callbackbetterCost, SWIG_Callback5_t callbackstateCost, SWIG_Callback6_t callbackmotionCost, SWIG_Callback7_t callbackcombineCosts, SWIG_Callback8_t callbackidentityCost, SWIG_Callback9_t callbackinfiniteCost, SWIG_Callback10_t callbackinitialCost, SWIG_Callback11_t callbackterminalCost, SWIG_Callback12_t callbackisSymmetric, SWIG_Callback13_t callbackaverageStateCost, SWIG_Callback14_t callbackmotionCostHeuristic, SWIG_Callback15_t callbackallocInformedStateSampler, SWIG_Callback16_t callback_print);

private:
    SWIG_Callback0_t swig_callbackisSatisfied;
    SWIG_Callback1_t swig_callbackisCostBetterThan;
    SWIG_Callback2_t swig_callbackisCostEquivalentTo;
    SWIG_Callback3_t swig_callbackisFinite;
    SWIG_Callback4_t swig_callbackbetterCost;
    SWIG_Callback5_t swig_callbackstateCost;
    SWIG_Callback6_t swig_callbackmotionCost;
    SWIG_Callback7_t swig_callbackcombineCosts;
    SWIG_Callback8_t swig_callbackidentityCost;
    SWIG_Callback9_t swig_callbackinfiniteCost;
    SWIG_Callback10_t swig_callbackinitialCost;
    SWIG_Callback11_t swig_callbackterminalCost;
    SWIG_Callback12_t swig_callbackisSymmetric;
    SWIG_Callback13_t swig_callbackaverageStateCost;
    SWIG_Callback14_t swig_callbackmotionCostHeuristic;
    SWIG_Callback15_t swig_callbackallocInformedStateSampler;
    SWIG_Callback16_t swig_callback_print;
    void swig_init_callbacks();
};

struct SwigDirector_ValidStateSamplerAllocatorDirector : public ValidStateSamplerAllocatorDirector, public Swig::Director {

public:
    SwigDirector_ValidStateSamplerAllocatorDirector();
    virtual ~SwigDirector_ValidStateSamplerAllocatorDirector();
    virtual ompl::base::ValidStateSamplerPtr Invoke(ompl::base::SpaceInformation const *arg0);

    typedef void * (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackInvoke);

private:
    SWIG_Callback0_t swig_callbackInvoke;
    void swig_init_callbacks();
};


#endif
