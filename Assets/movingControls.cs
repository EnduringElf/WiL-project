using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingControls : MonoBehaviour
{

    public float movementSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            transform.position += Vector3.back * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            transform.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            transform.position += Vector3.left * Time.deltaTime * movementSpeed;
        }






    }
}
