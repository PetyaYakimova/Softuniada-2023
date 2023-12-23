namespace Bottom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNodes = int.Parse(Console.ReadLine());
            int numberOfEdges = int.Parse(Console.ReadLine());

            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < numberOfEdges; i++)
            {
                int[] rowInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Edge edge = new Edge(rowInput[0], rowInput[1], rowInput[2]);
                edges.Add(edge);
            }

            edges = edges.OrderByDescending(e => e.Weight).ToList();

            int d = int.MaxValue;

            bool reachedFalseGraph = false;
            while (edges.Count>0)
            {
                d = edges[0].Weight;
                edges = edges.Where(e => e.Weight < d).ToList();
                for (int i = 0; i < numberOfNodes; i++)
                {
                    if (!edges.Any(e => e.StartNode == i || e.EndNode == i))
                    {
                        d++;
                        reachedFalseGraph = true;
                        break;
                    }
                }

                if (reachedFalseGraph)
                {
                    break;
                }
            }

            Console.WriteLine(d);
        }
    }

    internal class Edge 
    {
        public Edge(int startNode, int endNode, int weight)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Weight = weight;
        }
        public int StartNode { get; private set; }

        public int EndNode { get; private set; }

        public int Weight { get; private set; }
    }
}