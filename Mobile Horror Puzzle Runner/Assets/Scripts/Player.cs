using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool passedThroughDoor;
    public Light torch;
    private float count, randomFlickerTime;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 2f;
        randomFlickerTime = 0;
        count = 0;
        torch.enabled = true;
        passedThroughDoor = false;
        randomFlickerTime = Random.Range(0, 11f);
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count >= randomFlickerTime)
        {
            StartCoroutine(FlickerTorch());
            randomFlickerTime = 100f;
        }
    }
    IEnumerator FlickerTorch()
    {
        torch.enabled = false;
        yield return new WaitForSeconds(0.15f);
        torch.enabled = true;
        yield return new WaitForSeconds(0.15f);
        torch.enabled = false;
        yield return new WaitForSeconds(0.15f);
        torch.enabled = true;
        randomFlickerTime = Random.Range(5, 11f);
        count = 0;
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
