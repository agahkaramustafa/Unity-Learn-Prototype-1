using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchPlayer2 : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject secondCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mainCam.activeSelf == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                secondCam.SetActive(true);
                mainCam.SetActive(false);
            }

        }

        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                secondCam.SetActive(false);
                mainCam.SetActive(true);
            }
        }

    }
}
