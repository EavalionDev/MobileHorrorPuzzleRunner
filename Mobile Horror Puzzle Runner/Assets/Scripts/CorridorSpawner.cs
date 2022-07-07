using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorSpawner : MonoBehaviour
{
    public ObjectPools objPool;

    public GameObject spawningPos;
    private GameObject nextCorridorPiece;
    private float count;
    private int spawnCount = 0;
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
        if (other.CompareTag("CorridorWithDoor") || other.CompareTag("Corridor"))
        {
            if (spawningPos == null)
            {
                spawningPos = other.transform.Find("SpawnPos").gameObject;
            }
            if (spawnCount != 5)
            {
                nextCorridorPiece = objPool.corridorV1[0];
                objPool.corridorV1.Remove(nextCorridorPiece);
                nextCorridorPiece.transform.position = spawningPos.transform.position;
                spawnCount++;
            }
            else
            {
                nextCorridorPiece = objPool.doors[0];
                objPool.doors.Remove(nextCorridorPiece);
                nextCorridorPiece.transform.position = spawningPos.transform.position;
                spawnCount = 0;
            }
            spawningPos = null;
            
        }
    }
}
