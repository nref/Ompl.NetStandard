// https://stackoverflow.com/questions/32644268

%{
  #include <functional>
  #include <iostream>

  #ifndef SWIG_DIRECTORS
  #error "std_function.i: Directors must be enabled"
  #endif
%}

#define paramtype(num,type) $typemap(cstype,type)
#define param(num,type) $typemap(cstype,type) arg##num
#define unpack(num,type) arg##num
#define lvalref(num,type) type&& arg##num
#define forward(num,type) std::forward<type>(arg##num)

#define FE_0(...)
#define FE_1(action,a1) action(0,a1)
#define FE_2(action,a1,a2) action(0,a1), action(1,a2)
#define FE_3(action,a1,a2,a3) action(0,a1), action(1,a2), action(2,a3)
#define FE_4(action,a1,a2,a3,a4) action(0,a1), action(1,a2), action(2,a3), action(3,a4)
#define FE_5(action,a1,a2,a3,a4,a5) action(0,a1), action(1,a2), action(2,a3), action(3,a4), action(4,a5)

#define GET_MACRO(_1,_2,_3,_4,_5,NAME,...) NAME
%define FOR_EACH(action,...) 
  GET_MACRO(__VA_ARGS__, FE_5, FE_4, FE_3, FE_2, FE_1, FE_0)(action,__VA_ARGS__)
%enddef

//%define %std_function(Name, Ret, ...)
%define %std_function(Name, Ret, CsRet, ...)

    %feature("director") Name##Director;

    // typemap must come before the corresponding declaration
    %typemap(csclassmodifiers) Name##Director "public abstract class";
    %csmethodmodifiers Name##Director::Invoke "protected abstract";
    %typemap(csout) Ret Name##Director::Invoke ";" // Suppress the body of the abstract method

    %{
      struct Name##Director {
        virtual ~Name##Director() {}
        virtual Ret Invoke(__VA_ARGS__) = 0;
      };
    %}

    struct Name##Director {
      virtual ~Name##Director();
    protected:
      virtual Ret Invoke(__VA_ARGS__) = 0;
    };

    %typemap(maybereturn) SWIGTYPE "return ";
    %typemap(maybereturn) void "";

    %typemap(csin) std::function<Ret(__VA_ARGS__)> "$csclassname.getCPtr($csclassname.makeNative($csinput))"
    %typemap(cscode) std::function<Ret(__VA_ARGS__)> %{

        //public delegate Ret Name##Delegate(FOR_EACH(param, __VA_ARGS__));
        public delegate CsRet Name##Delegate(FOR_EACH(param, __VA_ARGS__));
                
        public class ConcreteDirector : Name##Director
        {
            public ConcreteDirector(Name##Delegate f)
            {
                _f = f;
            }

            //protected override Ret Invoke(FOR_EACH(param, __VA_ARGS__))
            protected override CsRet Invoke(FOR_EACH(param, __VA_ARGS__))
            {
                $typemap(maybereturn, Ret)_f.Invoke(FOR_EACH(unpack, __VA_ARGS__));
            }

            private readonly Name##Delegate _f;
        }

        public Name(Name##Delegate callback) 
        {
            _director = new ConcreteDirector(callback);
            _proxy = new $csclassname(_director);
            swigCPtr = _proxy.swigCPtr;
            swigCMemOwn = _proxy.swigCMemOwn;
        }

        public static $csclassname makeNative($csclassname f) {
            return null == f._director
                ? f
                : f._proxy;
        }

        private readonly Name##Director _director;
        private readonly $csclassname _proxy;
    %}

    %rename(Name) std::function<Ret(__VA_ARGS__)>;
    %rename(Invoke) std::function<Ret(__VA_ARGS__)>::operator();

    namespace std {
      struct function<Ret(__VA_ARGS__)> {
        // Copy constructor
        function<Ret(__VA_ARGS__)>(const std::function<Ret(__VA_ARGS__)>&);

        // Call operator
        Ret operator()(__VA_ARGS__) const;

        // Conversion constructor from function pointer
        function<Ret(__VA_ARGS__)>(Ret(*const)(__VA_ARGS__));

        // Construct with callback to C#
        %extend {
          function<Ret(__VA_ARGS__)>(Name##Director *in) {
            return new std::function<Ret(__VA_ARGS__)>([=](FOR_EACH(lvalref,__VA_ARGS__)){
                  return in->Invoke(FOR_EACH(forward,__VA_ARGS__));
            });
          }
        }
      };
    }

%enddef