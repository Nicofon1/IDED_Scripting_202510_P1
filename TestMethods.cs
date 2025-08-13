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
            Random random = new Random();

            for (int i = 0; i < list.Count - 1; i++)
            {            
                for (int j = 0; j < list.Count - i - 1; j++)
                {

                    if (list[j] > list[j + 1])
                    {
                        int a;
                        a = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = a;

                    }

                }

            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (value == list[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}