using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Array 사용\n");
            UseArray<int> ua = new UseArray<int>();
            Console.WriteLine("* 1 -> 2 -> 3 순서로 Push\n");
            ua.Push(1);
            ua.Push(2);
            ua.Push(3);
            Console.WriteLine("* 전부 POP\n");

            while (ua.GetTop() != -1)
            {
                Console.WriteLine(ua.Pop());
            }
            Console.WriteLine();

            Console.WriteLine("LinkedList 사용\n");
            UseLinkedList<String> uaList = new UseLinkedList<String>();
            Console.WriteLine("* ABC -> KSU -> OOP 순서로 Push");
            uaList.Push("ABC");
            uaList.Push("KSU");
            uaList.Push("OOP");
            
            Console.WriteLine("\n* Pop으로 OOP 삭제후 C# -> STACK 순서로 Push\n");
            Console.WriteLine(uaList.Pop()+"\n");
            uaList.Push("C#");
            uaList.Push("STACK");
            Console.WriteLine("* 전부 POP\n");

            while (uaList.GetTop() != -1)
            {
                Console.WriteLine(uaList.Pop());
            }
        }

        class UseArray<T>
        {
            T[] stack;
            int top = -1;

            public UseArray() {
                stack = new T[0];
            }

            public void Push(T data)
            {
                Array.Resize(ref stack, stack.Length + 1);
                stack[++top] = data;
            }
            public T Pop()
            {
                return stack[top--];
            }

            public int GetTop()
            {
                return top;
            }
        }

        class UseLinkedList<T>
        {
            LinkedList<T> stack;
            int top = -1;

            public UseLinkedList()
            {
                stack = new LinkedList<T>();
            }

            public void Push(T data) 
            {
                stack.AddLast(data);
                top++;
                
            }

            public T Pop()
            {
                T data;
                data = stack.Last();
                stack.RemoveLast();
                top--;

                return data;
            }

            public int GetTop()
            {
                return top;
            }
        }
    }

    
}
