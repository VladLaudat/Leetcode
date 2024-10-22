using System.Linq;
using System.Xml.Linq;

public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}

public class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node == null) return null;
        Node copiedGraph = new Node(node.val);
        Node traversalNode = copiedGraph;
        Dictionary<int, Node> visited = new Dictionary<int, Node>();
        Queue<Node> queue = new Queue<Node>();
        Queue<Node> queue2 = new Queue<Node>();
        queue.Enqueue(node);
        visited.Add(node.val, copiedGraph);
        traversalNode.neighbors = new List<Node>();
        queue2.Enqueue(traversalNode);

        while(queue.Count>0)
        {
            node = queue.Dequeue();
            traversalNode = queue2.Dequeue();

            foreach(Node neighbour in node.neighbors)
            {

                if (!visited.ContainsKey(neighbour.val))
                {
                    Node copiedGraphNeighbour = new Node(neighbour.val);
                    traversalNode.neighbors.Add(copiedGraphNeighbour);
                    copiedGraphNeighbour.neighbors.Add(traversalNode);

                    visited.Add(neighbour.val, copiedGraphNeighbour);

                    queue.Enqueue(neighbour);
                    queue2.Enqueue(copiedGraphNeighbour);
                }
                else
                {
                    Node copiedGraphNeighbour = visited[neighbour.val];
                    if (!traversalNode.neighbors.Contains(copiedGraphNeighbour))
                        {
                        traversalNode.neighbors.Add(copiedGraphNeighbour);
                        copiedGraphNeighbour.neighbors.Add(traversalNode);
                        }
                }
            }
        }
        return copiedGraph;
    }
}