using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCars : MonoBehaviour
{
    //public sprawia, ¿e widaæ to w inspectorze
    private float speed = 15;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);     
    }
}
