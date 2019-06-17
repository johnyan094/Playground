using System;

namespace PinGenerator
{
    public interface IRandomNumber
    {
        int GenerateNumber();
    }
    public class RandomNumber : IRandomNumber
    {
        private static int MaxNumber = 9;
        public int GenerateNumber()
        {
            var rdn = new Random();
            return rdn.Next(MaxNumber);
        }
    }
}
