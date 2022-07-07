using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool passedThroughDoor = false;
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
        if (other.CompareTag("Door"))
        {
            print("passed door");
            passedThroughDoor = true;
            StartCoroutine(TurnOffBool());
        }
    }
    IEnumerator TurnOffBool()
    {
        yield return new WaitForSeconds(1f);
        passedThroughDoor = false;
    }
}
