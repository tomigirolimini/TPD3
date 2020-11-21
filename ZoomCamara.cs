using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamara : MonoBehaviour
{
    public Camera Camara;
    float Size = 35.0f;

    void Start()
    {
        
    }


    void Update()
    {
        if (Puntaje.Puntos >= 0 && Puntaje.Puntos < 4)
        {
            if (Camara.orthographicSize >= 10.6f)
            {
                Size = Size - 0.5f;
                Camara.orthographicSize = Size;
            }

            if (Size <= 10.6f)
            {

                Camara.orthographicSize = 10.6f;

            }
        }

    }
}
