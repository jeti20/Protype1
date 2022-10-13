using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowWithoutSwitchSphare : MonoBehaviour
{
    public GameObject player;  
    private Vector3 offset = new Vector3(0, 2.25f, -2.5f);
    // LateUpdate funkcja jest wywo³ywana
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //transform.position = --> pozycja obiektu na którym jest skrypt
        // player.transform.position --> pozycja obiektu (zmiennej player)
        //offset --> zmienna Vectro3(0, 5, -7) która sprawia, ¿e jest dodawana do obecnej pozycji gracza, dziêki czemu kamera jest lekko za graczem


    }

}
