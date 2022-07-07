using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipDoor : MonoBehaviour
{
    public GameObject skipButton;

    void Update()
    {
        if (DoorStopCol.atDoor)
        {
            skipButton.SetActive(true);

        }
        else
        {
            skipButton.SetActive(false);
        }
    }
    public void SkipDoorButton()
    {
        if (DoorStopCol.atDoor)
        {
            DoorStopCol.atDoor = false;
        }
    }
}
