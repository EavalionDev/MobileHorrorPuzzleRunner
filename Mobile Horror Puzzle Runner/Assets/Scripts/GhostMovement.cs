using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public Transform player;
    public float speedForward, speedBackward;
    private bool moveForward;
    public static bool playerCaught;
    // Start is called before the first frame update
    void Start()
    {
        moveForward = true;
        playerCaught = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerCaught)
        {
            if (DoorStopCol.atDoor)
            {
                moveForward = true;
            }
            else
            {
                moveForward = false;
            }

            float dist = Vector3.Distance(gameObject.transform.position, player.position);
            if (moveForward)
            {
                if (dist > 10f)
                {
                    transform.position += new Vector3(0, 0, speedForward * Time.deltaTime);
                }
                else
                {
                    transform.position += new Vector3(0, 0, speedForward/2 * Time.deltaTime);
                }
            }
            else
            {
                transform.position -= new Vector3(0, 0, speedBackward * Time.deltaTime);
            }
        }
        else
        {
            transform.position = transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCaught = true;
        }
    }
}
