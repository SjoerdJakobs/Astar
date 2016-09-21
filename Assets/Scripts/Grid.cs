using UnityEngine;
using System.Collections;


public class Grid : MonoBehaviour {

    //Bool
    [SerializeField]
    private bool showGrid;//do you want to see the gizmo's in the editor?
    [SerializeField]
    private bool dynamicGrid;//do you want to update the grid for changes
    //Bool

    //LayerMasks
    [SerializeField]
    private LayerMask unwalkableMask;//the layermask that the obstacles will have where you cant walk.
                                     //LayerMasls

    //Vector2
    [SerializeField]
    private Vector2 gridSize;//a vector 2 that decides the size of the grid
    //Vector2

    //Float
    [SerializeField]
    private float enemyRadius;
    [SerializeField]
    private float refreshRate;
    [SerializeField]
    private float nodeRadius;//the radius of the node
    private float nodeDiameter;//the diameter of the nodes
    //Float

    //Scripts
    private Node[,] grid;//a 2d array of nodes that will make the grid
                          //Scripts


    //Int
    private int gridSizeX, gridSizeY;//the amount of nodes that wil be in a x line and a y line in the grid(magic trick: do x*y and you get all the nodes in the grid! :D)
                                       //Int

    // Use this for initialization
    void Awake () {
        CreateGrid();
	}

    void CreateGrid()
    {
        /*grid = new Node[xSize, ySize];
        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < xSize; y++)
            {
                Node node = new Node(new Vector3(x,0,y));
                
                grid[x, y] = node;
            }
        }*/
    }
    	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDrawGizmos()
    {
        /*for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < xSize; y++)
            {
                Gizmos.color = Color.white;
                Gizmos.DrawCube(grid[x, y]._position, new Vector3(0.5f, 0.5f,0.5f));
            }
        }*/
    }
}
