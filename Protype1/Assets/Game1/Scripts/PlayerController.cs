using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public sprawia, �e wida� to w inspectorze
    private float speed = 15;
    private float turnSpeed = 10;
    private float horizontalInput;
    private float VerticalInput;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        //Input --> input manager class
        //GetAxis(Horizontal) --> metoda. Horizontal odnosi sie do Horizontal w Edit>Project Settings >input manager>aes
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        // transform --> ma�a litera odnosi si� do komponentu naszego obiektu na kt�yrym jest skrypt
        // . --> kropka umo�liwia u�ycie metodt z r�znych klas i obiekt�w
        // Translate --> to jest metoda jak Update(). Ta metoda sprawia, �e po w��czeniu gry obiekt porusza si� z pr�dko�ci� 50-60m/s (co klatk�, ilo�� 50-60 zale�y od tego jak silny jest komputer)
        //Vector3 --> odnosi si� do osi x, y, z
        //forward --> to inaczej (0, 0, 1)
        // Time.detltaTime --> sprawia, �e porusza si� co kratk� bez wzgl�du na moc komputera 
        // transform.Translate(0, 0, 1); --> (x, y, z) prousza si� do przodu
        //transform.Translate(Vector3.forward) --> pozwala porusza� si� do przodu

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); //sprawia, �e skr�ca w prawo/lewo
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * turnSpeed * Time.deltaTime); // sprawia, �e skr�camy prawo i lewo + sprawia, �e pojazd si� rotuje
    }
}
