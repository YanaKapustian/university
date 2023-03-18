using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR16_kapustian
{
    internal class StringArray
    {
        private string[] data;
        private int[] lengths;
        public StringArray()
        {
            data = new string[0];
            lengths = new int[0];
        }
        public StringArray(string[] strings)
        {
            data = new string[strings.Length];
            lengths = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                data[i] = strings[i];
                lengths[i] = strings[i].Length;
            }
        }
        public int Length
        {
            get { return data.Length; }
        }
        public StringArray(string[] strings, int[] lengths)
        {
            if (strings.Length != lengths.Length)
            {
                throw new ArgumentException("Lengths array must have the same length as the strings array.");
            }
            data = strings;
            this.lengths = lengths;
        }
        public int[] Lengths
        {
            get { return lengths; }
            set
            {
                if (value.Length != data.Length)
                {
                    throw new ArgumentException("Lengths array must have the same length as the strings array.");
                }
                lengths = value;
            }
        }

        // звертання по індексу
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= data.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return data[index];
            }
            set
            {
                if (index < 0 || index >= data.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                data[index] = value;
                lengths[index] = value.Length;
            }
        }

        // формує новий масив з двох
        public static StringArray Concatenate(StringArray a, StringArray b)
        {
            string[] newData = new string[a.data.Length + b.data.Length];
            int[] newLengths = new int[newData.Length];
            Array.Copy(a.data, newData, a.data.Length);
            Array.Copy(b.data, 0, newData, a.data.Length, b.data.Length);
            Array.Copy(a.lengths, newLengths, a.lengths.Length);
            Array.Copy(b.lengths, 0, newLengths, a.lengths.Length, b.lengths.Length);
            return new StringArray(newData);
        }

        // формує новий масив з унікальними елементами
        public static StringArray Merge(StringArray a, StringArray b)
        {
            HashSet<string> uniqueElements = new HashSet<string>(a.data);
            uniqueElements.UnionWith(b.data);
            return new StringArray(uniqueElements.ToArray());
        }

        // виводить елемент за індексом
        public void PrintElement(int index)
        {
            Console.WriteLine("{0} = {1}", this[index], lengths[index]);
        }

        // виводить всі елементи масиву
        public void PrintAllElements()
        {
            for (int i = 0; i < data.Length; i++)
            {
                PrintElement(i);
            }
        }
    }

}
