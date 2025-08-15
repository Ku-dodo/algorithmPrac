using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n, int[,] wires)
    {
        List<Node> nodes = new List<Node>();
        for (int i = 0; i < n; i++)
        {
            nodes.Add(new Node());
        }

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            nodes[wires[i, 0] - 1].AddNode(nodes[wires[i, 1] - 1]);
            nodes[wires[i, 1] - 1].AddNode(nodes[wires[i, 0] - 1]);
        }

        DFS(nodes[0], null);


        int answer = int.MaxValue;
        foreach (var node in nodes)
        {
            if ((int)MathF.Abs(n - node.Count * 2) < answer)
            {
                answer = (int)MathF.Abs(n - node.Count * 2);
            }
        }

        return answer;
    }

    public int DFS (Node cNode, Node pNode)
    {
        int Count = 1;
        foreach(var node in cNode.Childs)
        {
            if (node != pNode)
            {
                Count += DFS(node, cNode);
            }
        }
        cNode.Count = Count;

        return Count;
    }
}

public class Node
{
    public List<Node> Childs = new List<Node>();
    public int Count;

    public void AddNode(Node node)
    {
        Childs.Add(node);
    }
}