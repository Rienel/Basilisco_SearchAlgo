using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

namespace AISearchSample
{
    class Fringe2 : Fringes
    {
        Stack<Node> dfs;
        Queue<Node> bfs;
        public Fringe2()
        {
            dfs = new Stack<Node>();
            bfs = new Queue<Node>();
        }

        public void add(Node n, Node origin)
        {
            n.Origin = origin;
            dfs.Push(n);
            bfs.Enqueue(n);
        }

        public Node remove()
        {
            if (dfs.Count != 0)
                return dfs.Pop();
            if (bfs.Count != 0)
                return bfs.Dequeue();
            return null;
        }
    }
}