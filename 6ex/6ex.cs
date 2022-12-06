using System;
//{
//    int n = 0;
//    string temp = p as string;
//    double t1=double.Parse(temp);  ---------  NE VUXODIT!!!!!!!!!!!!!!!!!
//    for (int i = 0; i != all.Length; i++)
//    {
//        string temp2 = all[i] as string;
//        if (temp2.CompareTo(temp) > 0)
//        {
//            n++;
//        }
//    }
//    Console.WriteLine(n);
//}


internal class Program
{
    //{
    //    class Box<T>
    //    {
    //        private T[] all;
    //        public Box(int a)
    //        {
    //            all = new T[a];
    //        }

    //        public void Add(T value, int i)
    //        {
    //            all[i] = value;
    //        }

    //        public void Swap(int i1, int i2)
    //        {
    //            T temp = all[i1];
    //            all[i1] = all[i2];
    //            all[i2] = temp;
    //        }
    //        public override string ToString()
    //        {
    //            foreach (T value in all)
    //            {
    //                Console.WriteLine(value);

    //            }
    //            return null;
    //        }

    //        public T this[int index]
    //        {
    //            get
    //            {
    //                return all[index];
    //            }
    //            set
    //            {
    //                all[index] = value;
    //            }
    //        }
    //        public void Compare(T p)
    //        {
    //            int n = 0;
    //            string temp = p as string;
    //            double t1 = double.Parse(temp);
    //            for (int i = 0; i != all.Length; i++)
    //            {
    //                string temp2 = all[i] as string;
    //                if (temp2.CompareTo(temp) > 0)
    //                {
    //                    n++;
    //                }
    //            }
    //            Console.WriteLine(n);
    //        }
    //    }

    class Box<T>
    {
        private T a;

        public T A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }
    }

    static void Compare(Box<double>[] all, double temp)
    {
        int n = 0;
        for (int i = 0; i < all.Length; i++)
        {
            if (all[i].A > temp)
            {
                n++;
            }
        }
        Console.WriteLine(n);
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        Box<double>[] all = new Box<double>[a];

        for (int i = 0; i < a; i++)
        {
            all[i] = new Box<double>();
            double temp = double.Parse(Console.ReadLine());
            all[i].A = temp;
        }
        Console.WriteLine();
        Compare(all, 7.55);
    }
}