using System;

namespace leetcode.csharp
{
    public class IsGraphBipartite
    {
        private bool res = true;
        private bool[] color;
        private bool[] visited;

        public bool IsBipartite(int[][] graph)
        {
            visited = new bool[graph.Length];
            color = new bool[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                if (!visited[i])
                {
                    traverse(graph, i);
                }
            }
            return res;
        }

        private void traverse(int[][] graph, int v)
        {
            if (!res)
            {
                return;
            }

            visited[v] = true;

            foreach (int neighbor in graph[v])
            {
                if (!visited[neighbor])
                {
                    color[neighbor] = !color[v];
                    traverse(graph, neighbor);
                }
                else
                {
                    if (color[neighbor] == color[v])
                    {
                        res = false;
                    }
                }
            }
        }

        // public static void Main(string[] args)
        // {
        //     IsGraphBipartite isGraphBipartite1 = new IsGraphBipartite();
        //     IsGraphBipartite isGraphBipartite2 = new IsGraphBipartite();
        //     int[][] graph1 =
        //     {
        //         new[] {1, 2, 3},
        //         new[] {0, 2},
        //         new[] {0, 1, 3},
        //         new[] {0, 2}
        //     };
        //     int[][] graph2 =
        //     {
        //         new[] {1, 3},
        //         new[] {0, 2},
        //         new[] {1, 3},
        //         new[] {0, 2}
        //     };
        //
        //     var res1 = isGraphBipartite1.IsBipartite(graph1);
        //     Console.WriteLine(res1);
        //
        //     var res2 = isGraphBipartite2.IsBipartite(graph2);
        //     Console.WriteLine(res2);
        // }
    }
}