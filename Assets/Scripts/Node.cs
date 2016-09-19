using UnityEngine;
using System.Collections;

public class Node
{
    public Vector3 _position;
    public bool _walkable;
    public float _gCost;
    public float _hCost;
    public float _fCost;

    public Node(Vector3 position, bool walkable, float gCost, float hCost)
    {
        _position = position;
        _walkable = walkable;
        _gCost = gCost;
        _hCost = hCost;
    }
}
