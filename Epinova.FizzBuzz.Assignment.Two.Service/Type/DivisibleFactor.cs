using System;

namespace Epinova.FizzBuzz.Assignment.Two.Service.Type
{
    public class DivisibleFactor
    {
        private int _factor;

        private string _word;

        public DivisibleFactor(int factor, string word)
        {
            Factor = factor;
            Word = word;
        }

        public int Factor
        {
            get => _factor;
            set => _factor = value <= 0
                ? throw new ArgumentException($"{nameof(Factor)} is {value}. Needs to be greater than zero")
                : value;
        }

        public string Word
        {
            get => _word;
            set => _word =
                value == null
                    ? throw new ArgumentNullException($"{nameof(Word)} is null")
                    :
                    value.Length == 0
                        ?
                        throw new ArgumentException($"{nameof(Word)} has zero letters. Needs one or more letters")
                        : value;
        }
    }
}