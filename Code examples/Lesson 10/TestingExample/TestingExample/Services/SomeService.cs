using System;

namespace TestingExample.Services
{
    public class SomeService : ISomeService
    {
        private readonly ISomeOtherService someOtherService;

        public SomeService(ISomeOtherService someOtherService)
        {
            this.someOtherService = someOtherService;
        }

        public bool DoSomeOtherThing(string parameterOne, bool parameterTwo)
        {
            return someOtherService.DoSomethingThatOthersRelyOn(parameterTwo)
                .Equals(parameterOne, StringComparison.InvariantCultureIgnoreCase);
        }

        public string DoSomething(bool parameterOne)
        {
            if(someOtherService.DoSomethingThatOthersRelyOn(parameterOne)
                .Equals("Awesome!", StringComparison.InvariantCultureIgnoreCase))
            {
                return "Awesome!";
            }

            return "Nooooo";
        }
    }
}
