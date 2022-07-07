using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public List<GameObject> objectsToDespawn = new List<GameObject>();
    public ObjectPools objPool;
    private CorridorMovement corridorScript;
    private CorridoorWithDoorMovement corridorWithDoorScript;

    private void Update()
    {
        if (Player.passedThroughDoor)
        {
            StartCoroutine(DespawnCorridors());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CorridorWithDoor") || other.CompareTag("Corridor"))
        {
            objectsToDespawn.Add(other.gameObject);
        }
    }
    IEnumerator DespawnCorridors()
    {
        yield return new WaitForSeconds(0f);
        foreach (GameObject corridor in objectsToDespawn)
        {
            if (corridor.CompareTag("CorridorWithDoor"))
            {
                objPool.doors.Add(corridor);
                corridorWithDoorScript = corridor.GetComponent<CorridoorWithDoorMovement>();
                corridorWithDoorScript.inPool = true;
                corridor.transform.position = objPool.transform.position;
            }
            if (corridor.CompareTag("Corridor"))
            {
                objPool.corridorV1.Add(corridor);
                corridorScript = corridor.GetComponent<CorridorMovement>();
                corridorScript.inPool = true;
                corridor.transform.position = objPool.transform.position;
            }
        }
        objectsToDespawn.Clear();
    }
}
