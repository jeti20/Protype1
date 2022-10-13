using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowWithoutSwitchSphare : MonoBehaviour
{
    public GameObject player;  
    private Vector3 offset = new Vector3(0, 2.25f, -2.5f);
    // LateUpdate funkcja jest wywo�ywana
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //transform.position = --> pozycja obiektu na kt�rym jest skrypt
        // player.transform.position --> pozycja obiektu (zmiennej player)
        //offset --> zmienna Vectro3(0, 5, -7) kt�ra sprawia, �e jest dodawana do obecnej pozycji gracza, dzi�ki czemu kamera jest lekko za graczem


    }

}
