using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStopCol : MonoBehaviour
{
    public static bool atDoor;
    // Start is called before the first frame update
    void Start()
    {
        atDoor = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            atDoor = true;
        }
    }
}
