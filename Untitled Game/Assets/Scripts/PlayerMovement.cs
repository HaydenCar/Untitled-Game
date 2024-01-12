using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rB;

    float movementSpeed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            rB.AddForce(0, 0, movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rB.AddForce((movementSpeed * -1) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rB.AddForce(0, 0, (movementSpeed * -1) * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rB.AddForce(movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
