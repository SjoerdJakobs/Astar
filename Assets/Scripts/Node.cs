using UnityEngine;
using System.Collections;

public class Node
{
    public Vector3 position { get; set; }

    public bool walkable { get; set; }

    public float gCost { get; set; }

    public float hCost { get; set; }

    public float terrainCost { get; set; }

    public float fCost
    {
        get { return gCost + hCost + terrainCost; }
    }

    public Node parentNode { get; set; }

    public void Reset()
    {
        gCost = 0;
        hCost = 0;
        parentNode = null;
    }

    public Node(Vector3 position, bool walkable = true, float gCost = 0, float hCost = 0)
    {
        position = position;
        walkable = walkable;
        gCost = gCost;
        hCost = hCost;
    }

}
