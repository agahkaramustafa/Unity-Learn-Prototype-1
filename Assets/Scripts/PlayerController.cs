using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Private variables
    [SerializeField] float speed;
    private Rigidbody playerRb;
    [SerializeField] private float horsePower;
    [SerializeField] float turnSpeed = 50.0f;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    private float horizontalInput;
    private float verticalInput;
    private float nosSpeed = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButton("NOS2"))
        {
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput * nosSpeed);
            transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

            playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput * nosSpeed);

        }

        else
        {
            // Move the vehicle forward
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            // Rotate the vehicle
            transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

            playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        }

        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
        speedometerText.SetText("Speed: " + speed + "kmh");
    }
}
