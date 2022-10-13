using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSetPosition : MonoBehaviour
{
    public float speed = 15;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.position += transform.right * Time.deltaTime * horizontalInput * speed;
        transform.position += transform.forward * Time.deltaTime * verticalInput * speed;
    }
}
