using System;

internal class Program
{
    static void FindWord(ref string v, ref string temp)
    {
        string b = "";
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] == ' ')
            {
                v = v.Remove(i, 1);
                break;
            }
            else
            {
                b += v[i];
                v = v.Remove(i, 1);
                i--;
            }
        }
        temp += b;
    }
    static int FindProbel(string v)
    {
        int a = 0;
        for(int i = 0; i != v.Length; i++)
        {
            if (v[i]==' ')
            {
                a++;
            }
        }
        return a;
    }

    static void DelProbel(ref string v)
    {
        for (int i = 0; i != v.Length; i++)
        {
            if (v[i] == ' ')
            {
                v = v.Remove(i, 1);
                break;
            }
        }
    }
    class Tuple<T,T2>
    {
        private T item1;
        private T2 item2;

        public T Item1
        {
            get
            {
                return item1;
            }

            set
            {
                item1 = value;
            }
        }
        public T2 Item2
        {
            get
            {
                return item2;
            }

            set
            {
                item2 = value;
            }
        }

        public Tuple(T a, T2 b)
        {
            Item1 = a;
            Item2 = b;
        }

        public void Print()
        {
            Console.WriteLine(Item1+" -> "+Item2);
        }

    }
    static void Main()
    {   
        while (true)
        {
            string temp = Console.ReadLine();
            int n = FindProbel(temp);
            Console.WriteLine(n);
            if (n == 2)
            {
                string temp2="";
                FindWord(ref temp, ref temp2);
                temp2 += ' ';
                FindWord(ref temp, ref temp2);
                Console.WriteLine(temp2+" "+temp);
                Tuple<string, string> a = new Tuple<string, string>(temp2, temp);
                a.Print();
            }
            else if(n == 1)
            {
                string temp2 = "";
                FindWord(ref temp, ref temp2);
                try
                {
                    int num2 = int.Parse(temp);
                    Tuple<string, int> a = new Tuple<string, int>(temp2, num2);
                    a.Print();
                }
                catch (Exception)
                {
                    try
                    {
                        int num1 = int.Parse(temp2);
                        DelProbel(ref temp);
                        double num2 = double.Parse(temp);

                        Tuple<int, double> a = new Tuple<int, double>(num1, num2);
                        a.Print();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}

