using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float Speed = 30;
    Rigidbody rb;
    public bool stop = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        transform.Translate(transform.forward * Speed * Time.deltaTime);
        if (stop)
        {
            Stop();
        }
    }

    public void Hit()
    {
        Speed = 0;
        rb.useGravity = true;
    }

    public void Stop()
    {
        if(Speed >= 0)
        {
            Speed -= 0.04f;
            if(Speed <= 0)
            {
                Speed = 0;
                stop = false;
            }
        }
    }
}
