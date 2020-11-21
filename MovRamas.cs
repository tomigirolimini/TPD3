using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovRamas : MonoBehaviour
{
    public GameObject RamaRota;
    public GameObject Rama;
  

    Renderer render;

    void Start()
    {

    }


    void Update()
    {
        
         if (transform.position != new Vector3(13, 35, 0))
         {
            transform.Translate(0, -0.4f, 0);

         }
        

        if (transform.position.y <= -17)
        {
            DestruirRama();
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Piedra")
        {

            SonidosSimples.sonidos = 3;
            DestruirRama();
            GameObject instanciaRamaRota = Instantiate(RamaRota, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }

        if(other.tag == "Disparo")
        {

            SonidosSimples.sonidos = 3;
            DestruirRama();
            GameObject instanciaRamaRota = Instantiate(RamaRota, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

        }

        if (other.tag == "Jugador")
        {
            SonidosSimples.sonidos = 4;
            DestruirRama();
            GameObject instanciaRamaRota = Instantiate(RamaRota, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

        }
    }

    void DestruirRama()
    {
  
        Puntaje.Objetos = Puntaje.Objetos - 1;
        Destroy(Rama);
        
    }

}
