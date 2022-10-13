using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyAddForce : MonoBehaviour
{
    public float force = 5;
    private Rigidbody rb;

    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        rb.AddForce(transform.right * force * Time.deltaTime * horizontalInput);
        rb.AddForce(transform.forward * force * Time.deltaTime * verticalInput);
    }
}
