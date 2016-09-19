using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Node))]
public class Grid : MonoBehaviour {
    private Node node;

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

            }
        }
    }
    	
	// Update is called once per frame
	void Update () {
	
	}
}
