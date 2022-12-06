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
        public override string ToString()
        {
            foreach (T value in all)
            {
                Console.WriteLine(value);

            }
            return null;
        }
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Box<string> all = new Box<string>(a);
        for(int i = 0; i < a; i++)
        {
            string temp=Console.ReadLine();
            all.Add(temp, i);
        }
        Console.WriteLine();
        all.ToString();
    }
}

