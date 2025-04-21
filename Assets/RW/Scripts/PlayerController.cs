using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject hay;

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 20)
        {
            transform.Translate(20 * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -20)
        {
            transform.Translate(-20 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(hay, transform.position + offset, Quaternion.identity);
        }
    }
}
