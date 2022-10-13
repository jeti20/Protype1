using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlatform1 : MonoBehaviour
{
    public float rotate = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotate);
    }
}
