using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static bool EsPrimo (int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            return 0;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            return null;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            return null;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            return null;
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            return false;
        }


        internal static List<int> ListaAzar(List<int> list)
        {
            List<int> listAzar = new List<int>();
            Random random = new Random();

            foreach (int i in list)
            {
                int num;
                num = random.Next();

                if (num < 100)
                {
                    listAzar.Add(num);
                }              
            }

            return null;
        }
    }
}