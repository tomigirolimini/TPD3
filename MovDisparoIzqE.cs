using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDisparoIzqE : MonoBehaviour
{
    public GameObject Disparo;
    public GameObject DisparoCae;
    int EscenaA;
    bool Activar = false;

    void Start()
    {
        EscenaA = Puntaje.Escena;
    }


    void Update()
    {

        if(EscenaA != Puntaje.Escena)
        {
            Destroy(gameObject);

        }

        transform.Translate(new Vector3(-0.1f, 0, 0));

        if (transform.position.x <= -1.5 && Activar == false)
        {
            Activar = true;

            SonidosSimples.sonidos = 2;

            GameObject instanciaDisparoCae = Instantiate(DisparoCae, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            Destroy(Disparo);

        }
    }

   void OnTriggerEnter2D(Collider2D other)
   {

        if (other.tag == "Jugador")
        {
            Destroy(gameObject);

        }

   }

}
