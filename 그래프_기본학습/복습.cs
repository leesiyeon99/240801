namespace 그래프_기본학습
{
    internal class 복습
    {

        public abstract class Graph
        {
            public abstract void Connect(int from, int to);
            public abstract void DisConnect(int from, int to);
            public abstract bool InConnect(int from, int to);
        }

        public class MatrixGraph : Graph
        {
            bool[,] matrixGraph;

            public MatrixGraph(int vertex)
            {
                matrixGraph = new bool[vertex, vertex];
            }

            public override void Connect(int from, int to)
            {
                matrixGraph[from, to] = true;
            }

            public override void DisConnect(int from, int to)
            {
                matrixGraph[from, to] = false;
            }

            public override bool InConnect(int from, int to)
            {
                return matrixGraph[from, to];
            }
        }

        public class ListGraph : Graph
        {
            List<int>[] list;

            public ListGraph(int vertex)
            {
                list = new List<int>[vertex];
                for (int i = 0; i < vertex; i++)
                {
                    list[i] = new List<int>();
                }
            }

            public override void Connect(int from, int to)
            {
                list[from].Add(to);
            }

            public override void DisConnect(int from, int to)
            {
                list[from].Remove(to);
            }

            public override bool InConnect(int from, int to)
            {
                return list[from].Contains(to);
            }
        }
    }
}