using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    Rigidbody rb;
    public float fowardthrust = 20f;
    public float turningspeed = 10f;

    public bool Active;
    float horizontalInput;
    float verticleInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Active == true)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticleInput = Input.GetAxis("Vertical");
            Vector3 dir = new Vector3(horizontalInput, 0, verticleInput);
            if (horizontalInput != 0)
            {
                horizontalInput = 0.5f * horizontalInput;
                rb.AddForce(dir.x * turningspeed, dir.y, 0);
            }
            if(verticleInput != 0)
            {
                rb.AddForce(0, 0, dir.z * fowardthrust);
            }
        }
        
        
    }
}
