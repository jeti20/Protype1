<<<<<<< HEAD:Protype1/Assets/Game1/Scripts/CameraFollow.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate funkcja jest wywo�ywana
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //transform.position = --> pozycja obiektu na kt�rym jest skrypt
        // player.transform.position --> pozycja obiektu (zmiennej player)
        //offset --> zmienna Vectro3(0, 5, -7) kt�ra sprawia, �e jest dodawana do obecnej pozycji gracza, dzi�ki czemu kamera jest lekko za graczem
    }
}
=======
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
>>>>>>> 07fa752d7834f48d817d4f1c79a1835ec7d2374c:Protype1/Assets/Scripts/CameraFollow.cs
