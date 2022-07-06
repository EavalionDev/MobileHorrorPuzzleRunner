using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorSpawner : MonoBehaviour
{
    public ObjectPools objPool;

    private GameObject spawningPos;
    private GameObject nextCorridorPiece;
    private float count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (spawningPos == null)
        {
            spawningPos = other.transform.Find("SpawnPos").gameObject;
        }
        nextCorridorPiece = objPool.corridorV1[0];
        objPool.corridorV1.Remove(nextCorridorPiece);
        nextCorridorPiece.transform.position = spawningPos.transform.position;
        spawningPos = null;
    }
}
