using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 0, 0);
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2, 1);
    // Start is called before the first frame update
    void Start()
    {
        offset = offset1;

        
    }

    // LateUpdate funkcja jest wywoływana
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //transform.position = --> pozycja obiektu na którym jest skrypt
        // player.transform.position --> pozycja obiektu (zmiennej player)
        //offset --> zmienna Vectro3(0, 5, -7) która sprawia, że jest dodawana do obecnej pozycji gracza, dzięki czemu kamera jest lekko za graczem
        

        if (Input.GetKeyDown(KeyCode.P))
        {
            offset = offset2;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            offset = offset1;
        }
    }

}
