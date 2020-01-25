using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mime;
using System.Threading;

namespace AverageTemplate
{
    class Program
    {
         static void Main(string[] args)
        {
            
            Console.WriteLine("Операция Average\n\n************\n");
            var d = new Average<decimal>();
            d.Add(5);
            d.Add(2);
            Console.WriteLine($"Среднее значение:{d.avverage()}");
            Console.ReadLine();
        }

    }
    class Average<T>
    {
        List<T> _numberList = new List<T>();
        public void Add(T value)
        {
            _numberList.Add(value);
        }
        public T avverage()
        {
            dynamic sum = 0;
            for (int i = 0; i < _numberList.Count; i++)
            {
                sum += _numberList[i];
            }

            return sum / _numberList.Count;
        }
        public void Reset()
        {
            _numberList.Clear();
        }
    }
}
