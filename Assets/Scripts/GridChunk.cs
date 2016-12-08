using UnityEngine;
using System.Collections;

public class GridChunk : MonoBehaviour {


    public Node[] NodeGridChunk(Vector3 Pos, int chunkSize, float spaceBetweenPoints, int walkableMasks, int detectableMasks, bool debugMode = false)
    {
        Node[] Chunk = new Node[chunkSize*chunkSize];
        int counter = 0;
        for(int y = 0; y < chunkSize; y++)
        {
            for(int x = 0; x<chunkSize; x++)
            {
                RaycastHit hit;
                if (Physics.Raycast(Pos + new Vector3(x, 100, y), Vector3.down, out hit, 200, detectableMasks, QueryTriggerInteraction.Ignore))
                {
                    Node newNode;
                    if (hit.transform.gameObject.layer == walkableMasks)
                    {
                        newNode = new Node(hit.point, true);
                    }
                    else
                    {
                        newNode = new Node(hit.point, false);
                    }
                    Chunk[counter] = newNode;
                }
            }
        }
        return (Chunk);
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
