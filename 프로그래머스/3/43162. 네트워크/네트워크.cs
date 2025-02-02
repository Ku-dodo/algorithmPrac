using System;
using System.Collections.Generic;

public class Solution
{

    public int solution(int n, int[,] computers)
    {
        List<Node> network = new List<Node>();
        for (int i = 0; i < computers.GetLength(0); i++)
        {
            network.Add(new Node());
        }

        for (int i = 0; i < computers.GetLength(0); i++)
        {
            for (int adj = 0; adj < computers.GetLength(1); adj++)
            {
                if (i != adj && computers[i, adj] == 1)
                {
                    network[i].adjNodeIndex.Add(adj);
                }
            }
        }
        int answer = 0;

        for (int i = 0; i < computers.GetLength(0); i++)
        {
            if (!network[i].visit)
            {
                BFSUtil(network, i);
                answer++;
            }
        }

        Console.WriteLine(answer);
        return answer;
    }

    class Node
    {
        public List<int> adjNodeIndex = new List<int>();
        public bool visit = false;
    }

    private void BFSUtil(List<Node> network, int index)
    {
        Queue<int> netQ = new Queue<int>();
        netQ.Enqueue(index);
        network[index].visit = true;

        while (netQ.Count > 0)
        {
            int q = netQ.Dequeue();

            foreach (int nodeIndex in network[q].adjNodeIndex)
            {
                if (!network[nodeIndex].visit)
                {
                    network[nodeIndex].visit = true;
                    netQ.Enqueue(nodeIndex);
                }
            }
        }
    }
}