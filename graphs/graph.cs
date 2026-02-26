using System;
using System.Collections.Generic;

public class Graph
{
    private Dictionary<string, List<string>> adj;
    private bool directed;

    public Graph(bool directed = false)
    {
        this.adj = new Dictionary<string, List<string>>();
        this.directed = directed;
    }

    public void AddNode(string node)
    {
        // TODO
    }

    public void AddEdge(string u, string v)
    {
        // TODO
    }

    public List<string> GetNeighbors(string node)
    {
        // TODO
        return null;
    }
}
