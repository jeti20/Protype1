using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerSwitch : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
    public Vector3 offset1 = new Vector3(0, 5, -7);
    public Vector3 offset2 = new Vector3(0, 2, 1);

    // Start is called before the first frame update
    void Start()
    {
        offset = offset1;
    }

    // LateUpdate funkcja jest wywo³ywana
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            cam2();
        }
        else
        {
            cam1();
        }

        void cam1()
        {
            transform.position = player.transform.position + offset1;
            transform.rotation = player.transform.rotation;
        }


        void cam2()
        {
            transform.position = player.transform.position + offset2;
            transform.rotation = player.transform.rotation;
        }
        //transform.position = --> pozycja obiektu na którym jest skrypt
        // player.transform.position --> pozycja obiektu (zmiennej player)
        //offset --> zmienna Vectro3(0, 5, -7) która sprawia, ¿e jest dodawana do obecnej pozycji gracza, dziêki czemu kamera jest lekko za graczem
    }
}
