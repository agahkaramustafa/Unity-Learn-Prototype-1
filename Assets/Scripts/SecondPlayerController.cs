using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    private float nosSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("ALeft");
        verticalInput = Input.GetAxis("WForward");

        if (Input.GetButton("NOS"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput * nosSpeed);
            transform.Rotate(Vector3.down, horizontalInput * turnSpeed * Time.deltaTime);
        }

        else
        {
            // Move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            // Rotate the vehicle
            transform.Rotate(Vector3.down, horizontalInput * turnSpeed * Time.deltaTime);
        }
        
    }
}
