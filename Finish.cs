using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool finishd = false;
    [SerializeField]private Transform Camera;
    [SerializeField]private Transform CamFinishPos;
    [SerializeField]private CarController car;


    AudioSource audioSource;
    void Start()
    {
        car = GameObject.Find("Player").GetComponent<CarController>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (finishd)
        {
            Camera.position = Vector3.Lerp(Camera.position, CamFinishPos.position, 0.1f);
            Camera.rotation = Quaternion.Lerp(Camera.rotation, CamFinishPos.rotation, 0.05f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            finishd = true;
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            car.stop = true;
            audioSource.enabled = true;
        }
    }
}
