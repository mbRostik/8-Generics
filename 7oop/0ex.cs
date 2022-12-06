using System;

internal partial class Program
{
    class Box<T>
    {
        private T temp;

        public T Temp
        {
            get
            {
                Console.Write(temp.GetType() + ": "); return temp;
            }

            set
            {
                temp = value;
            }
        }
    }
    static void Main()
    {
        Box<string> box = new Box<string>();
        box.Temp = "ghvfjk";
        Console.WriteLine(box.Temp);
    }
}

