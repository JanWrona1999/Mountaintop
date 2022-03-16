using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchLisci : MonoBehaviour
{
    public float speed = 0;
    Rigidbody rb;
    Vector3 EulAngVel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        EulAngVel = new Vector3(speed, speed, speed);
    }

    void Update()
    {

        Quaternion deltaRotation = Quaternion.Euler(EulAngVel * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}