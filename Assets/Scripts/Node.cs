using UnityEngine;
using System.Collections;

public class Node
{
    public Vector3 _position;
    public bool _walkable;
    public float _gCost;
    public float _hCost;
    public float _terrainCost;

    public Node _parentNode;

    public float fCost
    {
        get
        {
            return _gCost + _hCost;
        }
    }


    public Node(Vector3 position, bool walkable = true, float gCost = 0, float hCost = 0)
    {
        _position = position;
        _walkable = walkable;
        _gCost = gCost;
        _hCost = hCost;
    }

}
