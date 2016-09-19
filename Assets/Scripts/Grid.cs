using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Node))]
public class Grid : MonoBehaviour {

    public Node[,] grid;
    public Node[] _open;
    public Node[] _closed;


    private int xSize;
    private int ySize;
	// Use this for initialization
	void Start () {
	}

    void CreateGrid()
    {
        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < xSize; y++)
            {
                Node node = new Node(new Vector3(x,0,y));

                grid[x, y] = node;
            }
        }
    }
    	
	// Update is called once per frame
	void Update () {
	
	}
}
