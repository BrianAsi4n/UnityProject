using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * speed);
    }
}

