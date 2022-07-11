using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSounds : MonoBehaviour
{
    public AudioSource speaker;
    public AudioClip sound1, sound2, sound3, sound4;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, 5);
        if (index == 1)
        {
            speaker.clip = sound1;
            speaker.Play();
        }
        else if (index == 2)
        {
            speaker.clip = sound2;
            speaker.Play();
        }
        else if (index == 3)
        {
            speaker.clip = sound3;
            speaker.Play();
        }
        else if (index ==4)
        {
            speaker.clip = sound4;
            speaker.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!speaker.isPlaying)
        {
            int index = Random.Range(0, 5);
            if (index == 1)
            {
                speaker.clip = sound1;
                speaker.Play();
            }
            else if (index == 2)
            {
                speaker.clip = sound2;
                speaker.Play();
            }
            else if (index == 3)
            {
                speaker.clip = sound3;
                speaker.Play();
            }
            else if (index == 4)
            {
                speaker.clip = sound4;
                speaker.Play();
            }
        }
    }
}
