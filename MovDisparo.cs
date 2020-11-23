using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDisparo : MonoBehaviour
{
    public GameObject Disparo;
    public GameObject DisparoCae;

    int Distancia = 5;

    bool Activar = false;

    void Start()
    {

    }


    void Update()
    {
       switch(Puntaje.Nivel)
       {
            case 0:
                Distancia = 5;
                break;

            case 2:
                Distancia = 14;
                break;
       }

        if (Puntaje.Nivel == 1 )
        {
            transform.Translate(new Vector3(0, 0.2f, 0));

            if (transform.position.y >= 5 && Activar == false)
            {
                Activar = true;

                SonidosSimples.sonidos = 2;

                GameObject instanciaDisparoCae = Instantiate(DisparoCae, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

                Destroy(Disparo);

            }

        }

        if (Puntaje.Nivel == 2 || Puntaje.Nivel == 0)
        {
            transform.Translate(new Vector3(0, 0.2f, 0));

            if (transform.position.y >= Distancia && Activar == false)
            {
                Activar = true;

                SonidosSimples.sonidos = 2;

                GameObject instanciaDisparoCae = Instantiate(DisparoCae, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

                Destroy(Disparo);

            }

        }


    }

}
