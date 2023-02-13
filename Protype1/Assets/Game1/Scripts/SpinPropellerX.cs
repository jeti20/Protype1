using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotate = 25;
    // Update is called once per frame
    void Update(){
        transform.Rotate(Vector3.forward * rotate);
    }
}
