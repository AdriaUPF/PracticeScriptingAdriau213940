using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 movementspeed;

    // Start is called before the first frame update
    void Start()
    {
        movementspeed = new Vector3(0, 0, 20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementspeed * Time.deltaTime, Space.World);
    }
}
