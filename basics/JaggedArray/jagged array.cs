using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] network_nodes = new int[4][];
            network_nodes[0] = new int[3];
            network_nodes[1] = new int[7];
            network_nodes[2] = new int[2];
            network_nodes[3] = new int[5];
            int i, j;
            for (i = 0; i < network_nodes.Length; i++)//here network.length=4
                for (j = 0; j < network_nodes[i].Length; j++)//network_nodes.Length[i]=3,7,2,5
                    network_nodes[i][j] = i * j + 70;
            Console.WriteLine("Total number of network nodes:" + network_nodes.Length + "\n");

            for (i = 0; i < network_nodes.Length; i++)//here network.length=4
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    Console.Write("CPU usage at node " + i + " CPU " + j + ":");

                    Console.Write(network_nodes[i][j] + "%");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
