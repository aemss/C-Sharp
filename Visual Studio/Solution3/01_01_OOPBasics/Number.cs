using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _01_01_OOPBasics
{

    class Number
    {
        private int _SingleNumber = 3;   // field 
        private int[] _innerArray = { 10, 20, 30, 40, 50 };
        private String _description = String.Empty;
        public Number()
        {
            Console.WriteLine("Number sınıfından bir örnek(instance) üretildi.");
            Console.WriteLine($"Number:  {_SingleNumber:N0}");
        }

        public Number(int singleNumber, string description, int count = -1)
        {
            SingleNumber = singleNumber;
            Description = description;
            Count = count;
        }

        public Number(int[] arr) 
        {
            _innerArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) 
            {
                _innerArray[i] = arr[i];
            }
        }



        public int SingleNumber // Property
        {
            get
            {
                return _SingleNumber;
            }
            set
            {
                if (value < 0)
                    _SingleNumber = 0;
                else
                    _SingleNumber = value;
            }
        }





        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Count { get; set; }
        public int Min { get 
            {
                return FindMin();
            }
        }

        public int Max => FindMax();

        private int FindMin()
        {
            int min = _innerArray[0];
            for (int i = 1; i < _innerArray.Length; i++)
            {
                if (_innerArray[i] < min)
                    min = _innerArray[i];
            }
            return min;
        }

        public int FindMax()
        {
            int max = _innerArray[0];
            for (int i = 1; i < _innerArray.Length; i++)
            {
                if (_innerArray[i] > max)
                    max = _innerArray[i];
            }
            return max;
        }
        public int Find(int key)
        {
            for (int i = 0; i < _innerArray.Length; i++)
            {
                if (_innerArray[i] == key)
                    return i;
            }
            return -1; //eleman bulunamadı
        }


    }
       
}



