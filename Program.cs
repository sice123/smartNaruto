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
            setNodes(lst);
            int numOfNodes = count(lst);
            checkIfThree(lst);
        }

        static bool checkIfThree(Node<int> node)
        {

            if (count(node) % 3 == 0 && count(node) > 0)
            {
                int numberOfG = count(node) / 3;
                int[] fArry = new int[numberOfG];
                int[] sArry = new int[numberOfG];
                int[] tArry = new int[numberOfG];
                mArry(node, fArry, sArry, tArry, numberOfG);
                if (checkArrys(fArry , sArry , tArry) == true)
                {
                    return true;
                }
                return false;

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
        static void mArry(Node<int> node , int[] fArry , int[] sArry , int[] tArry , int numberOfG)
        {
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
        static bool checkArrys(int[] fArry , int[] sArry , int[] tArry)
        {
            for (int i = 0; i < fArry.Length; i++)
            {
                if (fArry[i] != sArry[i] || tArry[i] != fArry[i] || sArry[i] != fArry[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void setNodes(Node<int> node)
        {
            Random r = new Random();
            Node<int> newNode = new Node<int>(r.Next(1,5));
            while (node != null)
            {
                node = newNode;
            }
            node = node.GetNext();
        }


    }
}
