using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour
{
    public float speed;
    public Transform tabletUpPos, tabletDownPos;
    private bool arrivedAtDoor, tabletUp, tabletDown;
    // Start is called before the first frame update
    void Start()
    {
        arrivedAtDoor = false;
        tabletUp = false;
        tabletDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorStopCol.atDoor && !arrivedAtDoor)
        {
            tabletUp = true;
            arrivedAtDoor = true;
            PuzzleHandler.newPuzzle = true;
        }
        if (tabletUp)
        {
            transform.position = Vector3.Lerp(transform.position, tabletUpPos.position, speed * Time.deltaTime);
        }
        else if (tabletDown)
        {
            transform.position = Vector3.Lerp(transform.position, tabletDownPos.position, speed * Time.deltaTime);
        }

        if (!DoorStopCol.atDoor && tabletUp)
        {
            tabletUp = false;
            tabletDown = true;
            arrivedAtDoor = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tabletUp)
            {
                tabletUp = false;
                tabletDown = true;
            }
            else if (tabletDown)
            {
                tabletDown = false;
                tabletUp = true;
            }
        }
    }
    
}
