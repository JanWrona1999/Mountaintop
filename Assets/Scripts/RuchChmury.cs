using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchChmury : MonoBehaviour
{
    float speed = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        rb.velocity = new Vector3(1, 0, 0) * speed;
    }
}
