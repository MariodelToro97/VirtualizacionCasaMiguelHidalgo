using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Camara : MonoBehaviour {
	public Camera FPSCamera;

	public float horizontalSpeed;
	public float verticalSpeed;

	float h;
	float v;

    Vector3 originalPosition;

	// Use this for initialization
	void Start () {
        originalPosition = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        FPSCamera.transform.Rotate(-v, 0, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, 0.05f, 0.05f);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, 0.05f, -0.05f);
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.05f, 0.05f, 0);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0.05f, 0.05f, 0);
            }
            else
            {
                transform.Translate(0, 0.05f, 0);
            }
            

        } else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.1f, 0, 0.1f);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0.1f, 0, 0.1f);
            }
            else
            {
                transform.Translate(0, 0, 0.1f);
            }
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))  
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.1f, 0, -0.1f);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0.1f, 0, -0.1f);
            }
            else 
            {
                transform.Translate(0, 0, -0.1f);
            }
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.R))
        {
            transform.position = originalPosition;
        }

    }
}