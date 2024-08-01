namespace 그래프_기본학습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListGraph listGraph = new ListGraph(8);
            listGraph.Connect(0, 3);

            listGraph.Connect(1, 2);
            listGraph.Connect(1, 3);

            listGraph.Connect(2, 1);
            listGraph.Connect(2, 4);
            listGraph.Connect(2, 6);

            listGraph.Connect(3, 0);
            listGraph.Connect(3, 1);
            listGraph.Connect(3, 5);
            listGraph.Connect(3, 7);

            listGraph.Connect(4, 2);

            listGraph.Connect(5, 3);

            listGraph.Connect(6, 2);

            listGraph.Connect(7, 3);

            Console.WriteLine("-----리스트를 이용해 출력-----");
            for (int from = 0; from < 8; from++)
            {
                Console.WriteLine($"{from} 정점: ");
                for (int to = 0; to < 8; to++)
                {
                    if(listGraph.InConnect(from, to))
                    {
                        Console.WriteLine($"  {to} 정점");
                    }
                }
                Console.WriteLine();
            }

            Graph matrixGraph = new MatrixGraph(8);
            matrixGraph.Connect(0, 3);

            matrixGraph.Connect(1, 2);
            matrixGraph.Connect(1, 3);

            matrixGraph.Connect(2, 1);
            matrixGraph.Connect(2, 4);
            matrixGraph.Connect(2, 6);
          
            matrixGraph.Connect(3, 0);
            matrixGraph.Connect(3, 1);
            matrixGraph.Connect(3, 5);
            matrixGraph.Connect(3, 7);
            
            matrixGraph.Connect(4, 2);
            
            matrixGraph.Connect(5, 3);
            
            matrixGraph.Connect(6, 2);
            
            matrixGraph.Connect(7, 3);

            Console.WriteLine("-----인접행렬을 이용해 출력-----");
            for (int from = 0; from < 8; from++)
            {
                Console.WriteLine($"{from} 정점: ");
                for (int to = 0; to < 8; to++)
                {
                    if (matrixGraph.InConnect(from, to))
                    {
                        Console.WriteLine($"  {to} 정점");
                    }
                }
                Console.WriteLine();
            }

        }

        public abstract class Graph
        {
            public abstract void Connect(int from, int to);
            public abstract void DisConnect(int from, int to);
            public abstract bool InConnect(int from, int to);
        }

        public class MatrixGraph : Graph
        {
            private bool[,] graph;
            public MatrixGraph(int vertex)
            {
                graph = new bool[vertex, vertex];
            }

            public override void Connect(int from, int to)
            {
                graph[from, to] = true;
            }

            public override void DisConnect(int from, int to)
            {
                graph[from, to] = false;
            }

            public override bool InConnect(int from, int to)
            {
                return graph[from, to];
            }
        }

        public class ListGraph : Graph
        {
            private List<int>[] graph;
            public ListGraph(int vertex)
            {
                graph = new List<int>[vertex];
                for (int i = 0; i < vertex; i++)
                {
                    graph[i] = new List<int>();
                }
            }

            public override void Connect(int from, int to)
            {
                graph[from].Add(to);
            }

            public override void DisConnect(int from, int to)
            {
                graph[from].Remove(to);
            }

            public override bool InConnect(int from, int to)
            {
                return (graph[from].Contains(to));
            }
        }
    }
}
