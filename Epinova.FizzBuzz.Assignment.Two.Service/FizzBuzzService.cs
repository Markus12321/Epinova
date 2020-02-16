using System;
using System.Collections.Generic;
using System.Text;
using Epinova.FizzBuzz.Assignment.Common.Interface;
using Epinova.FizzBuzz.Assignment.Two.Service.CustomException;
using Epinova.FizzBuzz.Assignment.Two.Service.Type;

namespace Epinova.FizzBuzz.Assignment.Two.Service
{
    public class FizzBuzzService : IService
    {
        private bool _ascending;
        private int _count;


        public FizzBuzzService(int count, List<DivisibleFactor> divisibleFactors, bool ascending = true)
        {
            Count = count;
            DivisibleFactors = divisibleFactors;
            Ascending = ascending;
            SortFactors();
        }

        public List<DivisibleFactor> DivisibleFactors { get; }

        public bool Ascending
        {
            get => _ascending;
            set
            {
                _ascending = value;
                SortFactors();
            }
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
            if (DivisibleFactors.Count == 0)
                throw new FizzBuzzException($"{DivisibleFactors} is Empty");

            try
            {
                ProcessedList = new List<string>();
                ProcessedList.AddRange(Ascending
                    ? GetCustomFizzBuzzListAscending()
                    : GetCustomFizzBuzzListDescending());
            }
            catch (Exception e)
            {
                throw new FizzBuzzException(e.Message, e.InnerException);
            }
        }

        private IList<string> GetCustomFizzBuzzListAscending()
        {
            var data = new List<string>();
            var entry = new StringBuilder();


            for (var number = 1; number <= Count; number++)
            {
                foreach (var divisibleFactor in DivisibleFactors)
                    if (number % divisibleFactor.Factor == 0)
                        entry.Append($"{divisibleFactor.Word}");

                if (entry.Length == 0)
                    entry.Append(number.ToString());

                data.Add(entry.ToString());
                entry.Clear();
            }

            return data;
        }

        private IList<string> GetCustomFizzBuzzListDescending()
        {
            var data = new List<string>();
            var entry = new StringBuilder();

            for (var number = Count; number >= 1; number--)
            {
                foreach (var divisibleFactor in DivisibleFactors)
                    if (number % divisibleFactor.Factor == 0)
                        entry.Append($"{divisibleFactor.Word}");

                if (entry.Length == 0)
                    entry.Append(number.ToString());

                data.Add(entry.ToString());
                entry.Clear();
            }

            return data;
        }

        private void SortFactors()
        {
            DivisibleFactors.Sort((x, y) => Ascending ? x.Factor - y.Factor : y.Factor - x.Factor);
        }
    }
}