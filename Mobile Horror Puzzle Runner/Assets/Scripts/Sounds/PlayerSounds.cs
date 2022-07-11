using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    public float stepTimer;
    public AudioSource speaker;
    public AudioClip step1, step2, step3;
    private bool startSounds;
    // Start is called before the first frame update
    void Start()
    {
        startSounds = false;
        int index = Random.Range(0, 4);
        if (index == 1)
        {
            speaker.clip = step1;
        }
        else if (index == 2)
        {
            speaker.clip = step2;
        }
        else if (index == 3)
        {
            speaker.clip = step3;
        }
        speaker.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!DoorStopCol.atDoor && !startSounds)
        {
            StartCoroutine(MakeStep());
            startSounds = true;
        }
    }
    IEnumerator MakeStep()
    {
        while (!DoorStopCol.atDoor)
        {
            int index = Random.Range(0, 4);
            if (index == 1)
            {
                speaker.clip = step1;
            }
            else if (index == 2)
            {
                speaker.clip = step2;
            }
            else if (index == 3)
            {
                speaker.clip = step3;
            }
            speaker.Play();
            yield return new WaitForSeconds(stepTimer);
        }
        startSounds = false;

    }
}
