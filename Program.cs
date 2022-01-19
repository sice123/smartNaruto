using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Node<int> lst = new Node<int>(5);
            int numOfNodes = count(lst);

        }
        
        static bool checkIfThree(Node<int> node)
        {
            
            if (count(node) % 3 == 0 && count(node) > 0)
            {
                int numberOfG = count(node) / 3;
                int[] fArry = new int[numberOfG];
                int[] sArry = new int[numberOfG];
                int[] tArry = new int[numberOfG];
                for (int i = 0; i < numberOfG; i++)
                {
                    fArry[i] = node.GetInfo();
                    node = node.GetNext();
                }
                for (int i = 0; i < numberOfG; i++)
                {
                    sArry[i] = node.GetInfo();
                    node = node.GetNext();
                }
                for (int i = 0; i < numberOfG; i++)
                {
                    tArry[i] = node.GetInfo();
                    node = node.GetNext();
                }
                
            }
            else
            {
                return false;
            }
        }
        static int count(Node<int> node)
        {
            int count = 0;
            while (node != null)
            {
                count++;
            }
            return count;
        }


    }
}
