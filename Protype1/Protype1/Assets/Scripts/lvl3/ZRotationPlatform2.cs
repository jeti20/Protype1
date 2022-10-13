using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZRotationPlatform2 : MonoBehaviour
{
    public float rotate = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotate);
    }
}
