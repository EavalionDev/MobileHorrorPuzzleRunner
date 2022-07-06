using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorMovement : MonoBehaviour
{
    public ObjectPools objPool;
    public float speed;
    public bool inPool = true;
    private Vector3 movePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objPool.corridorV1.Contains(gameObject))
        {
            inPool = true;
        }
        else
        {
            inPool = false;
        }
        if (!inPool && !DoorStopCol.atDoor)
        {
            Move();
        }
        movePos = new Vector3(0, 0, speed * Time.deltaTime);
    }
    void Move()
    {
        transform.position -= movePos;
    }
}
