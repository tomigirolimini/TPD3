using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDisparoDerE : MonoBehaviour
{
    public GameObject Disparo;
    public GameObject DisparoCae;
    int DisparoN;
    bool Activar = false;
    int EscenaA;
    void Start()
    {
        EscenaA = Puntaje.Escena;
    }


    void Update()
    {
        if (EscenaA != Puntaje.Escena)
        {
            Destroy(gameObject);

        }

        if (CambiodeEscena.DisparoN == 1)
        {
            transform.Translate(new Vector3(0.1f, 0, 0));

            if (transform.position.x >= 1.5f && Activar == false)
            {
                Activar = true;

                SonidosSimples.sonidos = 2;

                GameObject instanciaDisparoCae = Instantiate(DisparoCae, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

                Destroy(Disparo);

            }
        }

        if (CambiodeEscena.DisparoN == 2)
        {
            transform.Translate(new Vector3(0, -0.2f, 0));

            if (transform.position.y <= -3 && Activar == false)
            {
                Activar = true;

                SonidosSimples.sonidos = 2;

                GameObject instanciaDisparoCae = Instantiate(DisparoCae, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

                Destroy(Disparo);

            }
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
