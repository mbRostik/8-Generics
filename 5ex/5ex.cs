using System;

internal class Program
{
    class Box<T>
    {
        private T[] all;
        public Box(int a)
        {
            all = new T[a];
        }

        public void Add(T value, int i)
        {
            all[i] = value;
        }

        public void Swap(int i1, int i2)
        {
            T temp = all[i1];
            all[i1] = all[i2];
            all[i2] = temp;
        }
        public override string ToString()
        {
            foreach (T value in all)
            {
                Console.WriteLine(value);

            }
            return null;
        }

        public T this[int index]
        {
            get
            {
                return all[index];
            }
            set
            {
                all[index] = value;
            }
        }
        public void Compare(T p)
        {
            int n = 0;
            string temp = p as string;
            for(int i = 0; i != all.Length; i++)
            {
                string temp2 = all[i] as string;
                if (temp2.CompareTo(temp)>0)
                {
                    n++;
                }
            }
            Console.WriteLine(n);
        }
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Box<string> all = new Box<string>(a);
        for (int i = 0; i < a; i++)
        {
            string temp = Console.ReadLine();
            all.Add(temp, i);
        }
        Console.WriteLine();
        all.ToString();
        all.Compare("aa");
    }
}

