using System;
using System.Collections.Generic;
using System.Linq;

namespace PinGenerator
{
    public class Generate
    {
        private IRandomNumber _rdn { get; set; }
        private static int MaxPinLength = 4;
        public Generate(IRandomNumber rdn)
        {
            _rdn = rdn;
        }

        public string GenreatePin()
        {
            List<int> genreatedPins = new List<int>();
            //generate 1st number
            genreatedPins.Add(_rdn.GenerateNumber());

            while (genreatedPins.Count < MaxPinLength)
            {
                int pin = _rdn.GenerateNumber();

                if (ValidatePin(pin, genreatedPins))
                {
                    genreatedPins.Add(pin);
                }
            }

            return String.Join("", genreatedPins);
        }

        private bool ValidatePin(int pin, List<int> genreatedPins)
        {
            bool validateSeq = ValidateSeq(pin, genreatedPins);
            bool validateRepeat = ValidateRepeat(pin, genreatedPins);

            if (validateRepeat && validateSeq)
            {
                return true;
            }

            return false;
        }

        private bool ValidateRepeat(int pin, List<int> genreatedPins)
        {
            foreach (int num in genreatedPins)
            {
                if (num == pin)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidateSeq(int pin, List<int> genreatedPins)
        {
            int last = genreatedPins.Last();
            if ((pin + 1) == last || (pin - 1) == last)
            {
                return false;
            }

            return true;
        }
    }
}
