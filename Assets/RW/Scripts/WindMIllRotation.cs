using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMIllRotation : MonoBehaviour
{
    public Vector3 rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = new Vector3(0, 30, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed*Time.deltaTime);
    }
}
