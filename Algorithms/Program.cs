using System;
using BreadthFirst;
using BreadthFirstAlgorithm.Dependents;
using DisjointSetsDataStructure;

namespace BreadthFirst
{
    partial class Program
    {
        static void Main(string[] args)
        {
            #region BreadthFirstAlgorithm
            //var bfs = new BreadthFirstAlgorithm();
            //Employee root = bfs.BuildEmployeeGraph();
            //Console.WriteLine("Traverse Graph\n------");
            //bfs.Traverse(root);

            //Console.WriteLine("\nSearch in Graph\n------");
            //Employee e = bfs.Search(root, "Eva");
            //Console.WriteLine(e == null ? "Employee not found" : e.name);
            //e = bfs.Search(root, "Brian");
            //Console.WriteLine(e == null ? "Employee not found" : e.name);
            //e = bfs.Search(root, "Soni");
            //Console.WriteLine(e == null ? "Employee not found" : e.name);
            #endregion


            #region MyRegion
            //vertices
            //int[] vertices = new int[] { 1, 2, 3, 5, 6 };
            //just a bigger number than highest value of vertices

            int[] vertices = new int[] { 0, 1, 2, 3, 4 };


            Set set = new Set(100);
            foreach (int vertex in vertices)
            {
                set.MakeSet(vertex);
            }
            //unions
            //set.Union(2, 3);
            //set.Union(5, 6);
            //set.Union(3, 6);
            //set.Union(6, 1);

            set.Union(1, 0);
            set.Union(2, 4);
            set.Union(1, 3);
            set.Union(3, 0);
            set.Union(4, 0);

            //printing final set
            foreach (int vertex in vertices)
            {
                Console.WriteLine("parent of {0} is: {1} and rank is: {2}", vertex, set.FindImmidiateParent(vertex), set.FindRank(vertex));
            }

            Console.ReadLine();
            #endregion
        }
    }
}
