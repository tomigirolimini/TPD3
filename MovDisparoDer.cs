using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDisparoDer : MonoBehaviour
{
    public GameObject Disparo;
    public GameObject DisparoCae;

    bool Activar = false;

    void Start()
    {

    }


    void Update()
    {

        transform.Translate(new Vector3(0.1f, 0, 0));

        if (transform.position.x >= 5 && Activar == false)
        {
            Activar = true;

            SonidosSimples.sonidos = 2;

            GameObject instanciaDisparoCae = Instantiate(DisparoCae, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            Destroy(Disparo);

        }
    }
}
