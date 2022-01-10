using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;
using Unit4.UtilsLib;
using Unit4.TurtleLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> newNode = new Node<int>(5);

        }
        static bool check(Node<int> n , int c)
        {
            while (n != null)
            {
                
                if (n.GetInfo() == c)
                {
                    return true;
                }
                n = n.GetNext();



            }
            return false;   
        }
        static void getPlace(Node<int> n ,  int c)
        {
            int count = 1;
            int value = 0;
            while (n != null)
            {
                if (n.GetInfo() == c)
                {
                    value = count;
                }
                n = n.GetNext();
                count++;
            }
            Console.WriteLine("the int is in the " + value + " place");
        }
        static void setPlace(Node<int> node , int first , int replace)
        {
            Node<int> newNode = new Node<int>(replace);
            while (node != null)
            {
                if (node.GetInfo() == first)
                {
                    node = newNode;
                    return;
                }
                node = node.GetNext();
                
            }
            Console.WriteLine("no match");
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
        static void delete(Node<int> node , int del)
        {
            Node<int> last = null;
            while (node != null)
            {

                if (node.GetInfo() == del)
                {
                   
                }
                last = node;
            }
        }
        
    }
}
