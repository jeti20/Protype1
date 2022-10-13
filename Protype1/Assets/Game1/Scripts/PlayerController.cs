using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public sprawia, ¿e widaæ to w inspectorze
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
        // transform --> ma³a litera odnosi siê do komponentu naszego obiektu na któyrym jest skrypt
        // . --> kropka umo¿liwia u¿ycie metodt z róznych klas i obiektów
        // Translate --> to jest metoda jak Update(). Ta metoda sprawia, ¿e po w³¹czeniu gry obiekt porusza siê z prêdkoœci¹ 50-60m/s (co klatkê, iloœæ 50-60 zale¿y od tego jak silny jest komputer)
        //Vector3 --> odnosi siê do osi x, y, z
        //forward --> to inaczej (0, 0, 1)
        // Time.detltaTime --> sprawia, ¿e porusza siê co kratkê bez wzglêdu na moc komputera 
        // transform.Translate(0, 0, 1); --> (x, y, z) prousza siê do przodu
        //transform.Translate(Vector3.forward) --> pozwala poruszaæ siê do przodu

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); //sprawia, ¿e skrêca w prawo/lewo
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * turnSpeed * Time.deltaTime); // sprawia, ¿e skrêcamy prawo i lewo + sprawia, ¿e pojazd siê rotuje
    }
}
