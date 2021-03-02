 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class moveCube : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.velocity = Vector3.back * speed * Time.deltaTime;
    }
}
