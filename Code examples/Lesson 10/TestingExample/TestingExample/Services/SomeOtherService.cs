namespace TestingExample.Services
{
    public class SomeOtherService : ISomeOtherService
    {
        public string DoSomethingThatOthersRelyOn(bool parameterOne)
        {
            if(parameterOne == true)
            {
                return "Awesome!";
            }

            return "Crap...";
        }
    }
}
