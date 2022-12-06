using System;
using System.Collections.Generic;

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
        temp = b;
    }
    class Box<T>
    {
        private T[] all = Array.Empty<T>();

        public void Add(T temp)
        {
            T[] all2 = new T[all.Length + 1];
            for (int i = 0; i < all.Length; i++)
            {
                all2[i] = all[i];
            }
            all2[all2.Length - 1] = temp;
            all = new T[all2.Length];
            for (int i = 0; i != all.Length; i++)
            {
                all[i] = all2[i];
            }
        }

        public void Remove(int n)
        {
            n--;
            T[] all2 = new T[all.Length - 1];
            int b = 0;
            for (int i = 0; i < all.Length; i++)
            {
                if (i != n)
                {
                    all2[b] = all[i];
                    b++;
                }
            }

            all = new T[all2.Length];
            for (int i = 0; i != all.Length; i++)
            {
                all[i] = all2[i];
            }
        }

        public void Print()
        {
            for (int i = 0; i < all.Length; i++)
            {
                Console.WriteLine(all[i]);
            }

        }

        public bool Contain(T temp)
        {
            string t1 = "";
            t1 += temp;
            for (int i = 0; i != all.Length; i++)
            {
                string t2 = "";
                t2 += all[i];
                if (String.Compare(t1, t2) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int i1, int i2)
        {
            i1--;
            i2--;
            T temp = all[i1];
            all[i1] = all[i2];
            all[i2] = temp;
        }

        public int Greater(T a)
        {
            int k = 0;
            string t1 = "";
            t1 += a;
            for (int i = 0; i != all.Length; i++)
            {
                string t2 = "";
                t2 += all[i];
                if (String.Compare(t1, t2) == -1)
                {
                    k++;
                }
            }
            return k;
        }

        public T Min()
        {
            string t1 = "";
            t1 += all[0];
            int n = 0;
            for (int i = 0; i != all.Length; i++)
            {
                string t2 = "";
                t2 += all[i];
                if (String.Compare(t1, t2) > 0)
                {
                    n = i;
                    t1 = t2;
                }
            }
            return all[n];
        }

        public T Max()
        {
            string t1 = "";
            t1 += all[0];
            int n = 0;
            for (int i = 0; i != all.Length; i++)
            {
                string t2 = "";
                t2 += all[i];
                if (String.Compare(t1, t2) < 0)
                {
                    n = i;
                    t1 = t2;
                }
            }

            return all[n];
        }

        public void Sort()
        {
            Array.Sort(all);
        }
    }
    static void Main()
    {
        Box<string> all = new Box<string>();
        string temp = "";
        while (true)
        {
            temp = Console.ReadLine();
            if (temp == "END" || temp == "End" || temp == "end")
            {
                break;
            }

            string temp2 = "";
            FindWord(ref temp, ref temp2);

            if (temp2 == "Add")
            {

                all.Add(temp);
            }
            else if (temp2 == "Remove")
            {
                int i = int.Parse(temp);
                all.Remove(i);
            }
            else if (temp2 == "Print")
            {
                Console.WriteLine();
                all.Print();
                Console.WriteLine();
            }
            else if (temp2 == "Contain")
            {
                Console.WriteLine(all.Contain(temp));
            }
            else if (temp2 == "Min")
            {
                Console.WriteLine(all.Min());
            }
            else if (temp2 == "Max")
            {
                Console.WriteLine(all.Max());
            }
            else if (temp2 == "Swap")
            {
                string temp3 = "";
                FindWord(ref temp, ref temp3);
                for (int i = 0; i != temp.Length; i++)
                {
                    if (temp[i] == ' ')
                    {
                        temp = temp.Remove(i, 1);
                        break;
                    }
                }
                for (int i = 0; i != temp3.Length; i++)
                {
                    if (temp3[i] == ' ')
                    {
                        temp3 = temp3.Remove(i, 1);
                        break;
                    }
                }
                int i1 = int.Parse(temp3);
                int i2 = int.Parse(temp);
                all.Swap(i1, i2);
            }
            else if (temp2 == "Greater")
            {
                Console.WriteLine(all.Greater(temp));
            }
            else if (temp2 == "Sort")
            {
                all.Sort();
            }
            else
            {
                Console.WriteLine("4to-to ne to\n");
            }

        }
    }
}