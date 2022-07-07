using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool passedThroughDoor;
    // Start is called before the first frame update
    void Start()
    {
        passedThroughDoor = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            print("passed door");
            passedThroughDoor = true;
            ScoreHandler.addToDoorClearCount = true;
            StartCoroutine(TurnOffBool());
        }
    }
    IEnumerator TurnOffBool()
    {
        yield return new WaitForSeconds(1f);
        passedThroughDoor = false;
    }
}
