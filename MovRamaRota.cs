using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovRamaRota : MonoBehaviour
{
    public GameObject RamaRota;
    public int velocidad = 6;



    void Start()
    {
    }


    void Update()
    {


        if (transform.position != new Vector3(13, -18, 0))
        {
            transform.Translate(Vector3.down * Time.deltaTime * velocidad);

        }

        if (transform.position.y <= -17)
        {
            DestruirRama();
        }

    }

    void DestruirRama()
    {

        Destroy(RamaRota);

    }

}


