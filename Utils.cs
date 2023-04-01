namespace TheArena
{
    class Utils
    {

        // this method waits for the amount of time specified by the parameter to wait
        public void WaitFunction(int secondsToWait)
        {
            secondsToWait *= 1000;
            Thread.Sleep(secondsToWait);
        }

        // this method returns true-false based on the validity of the string input
        // in this case the string cannot be null or empty
        public bool TestForNullOrEmpty(string input)
        {
            bool result;
            return result = (String.IsNullOrEmpty(input) ? true : false);
        }

        // this method returns true-false based on the validity of the string input
        // in this case the string length cannot exceed 25 characters
        public bool TestForNameLength(string input)
        {
            bool result;
            return result = (input.Count() > 25) ? true : false;
        }
    }
}