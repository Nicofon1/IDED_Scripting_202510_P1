using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static bool EsPrimo (uint numero)
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
            Stack<uint> temp = new Stack<uint>();
            uint primerPrimo = 0;
            for (;0<stack.Count;)
            {
                temp.Push(stack.Pop());


            }
            for (; temp.Count > 0;)
            {
                uint tem = temp.Pop();
                if (EsPrimo(tem))
                {
                    primerPrimo = (uint)tem;
                }
                stack.Push(tem);
            }
            return primerPrimo;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> temp = new Stack<uint>();
            bool primerPrimoEliminado = false;
            for (; 0 < stack.Count;)
            {

                uint tem = stack.Pop();
                if (EsPrimo(tem) && !primerPrimoEliminado)
                    primerPrimoEliminado = true;
                else
                    temp.Push(tem);

            }
            for (; temp.Count > 0;)
            {
                stack.Push(temp.Pop());


            }
            return stack;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Stack<uint> temp = new Stack<uint>();
            Queue<uint> queue = new Queue<uint>();
            for (; 0 < stack.Count;)
            {
                queue.Enqueue(stack.Pop());

                temp.Push(stack.Pop());

            }
            for (; 0 < temp.Count;)
            {


            }
            return queue;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            Stack<uint> temp = new Stack<uint>();
            List<uint> list = new List<uint>();
            for (; 0 < stack.Count;)
            {

                temp.Push(stack.Pop());

            }
            for (; 0 < temp.Count;)
            {

                list.Add(temp.Pop());

            }


            return list;
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

            for (int i = 0; i < list.Count; i++)
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