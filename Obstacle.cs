using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float score = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<CarController>() != null)
        {
            CarController car = collision.gameObject.GetComponent<CarController>();
            car.Hit();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<RoadTrigger>() != null)
        {
            other.GetComponent<RoadTrigger>().AddScore(score);
        }
    }
}
