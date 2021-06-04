using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    private float distance;

    void Update()
    {
        GetControlls();
    }

    void GetControlls()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.transform;
                if (target.GetComponent<Obstacle>() == null)
                {
                    target = null;
                    return;
                }
                offset = target.position - hit.point;
                distance = hit.distance;
            }
        }
        if (Input.GetMouseButton(0) && !Input.GetMouseButtonDown(0) && target != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            target.position = ray.origin + ray.direction * distance + offset;
        }
        if (Input.GetMouseButtonUp(0))
            target = null;
    }
}

