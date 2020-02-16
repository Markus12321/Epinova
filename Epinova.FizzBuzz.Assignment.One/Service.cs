using System;
using System.Collections.Generic;
using Epinova.FizzBuzz.Assignment.Common.Interface;

namespace Epinova.FizzBuzz.Assignment.One
{
    public class Service : IService
    {
        private int _count;

        public Service(int count)
        {
            Count = count;
        }

        public List<string> ProcessedList { get; private set; }

        public int Count
        {
            get => _count;
            set => _count = value <= 0
                ? throw new ArgumentException($"{nameof(Count)} is {value}. It need to be greater than 0")
                : value;
        }

        public void Print()
        {
            ProcessedList.ForEach(x => Console.WriteLine($"{x}"));
        }

        public void Process()
        {
            if (Count <= 0)
                throw new ArgumentException($"{nameof(Count)} is {Count}. It needs to be greater than zero");

            ProcessedList = new List<string>(Count);

            var entry = string.Empty;

            for (var i = 1; i <= Count; i++)
            {
                if (i % 3 == 0)
                    entry += "Fizz";

                if (i % 5 == 0)
                    entry += "Buzz";


                if (string.IsNullOrEmpty(entry))
                    entry += i;

                ProcessedList.Add(entry);
                entry = string.Empty;
            }
        }
    }
}