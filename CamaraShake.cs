using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraShake : MonoBehaviour
{
    public Camera Camara;
    public float Duracion;
    public float Intensidad;
    float Size = 10.6f;

    float Rotacion = 360.0f;

    void Start()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 155);
    }

    public void shake(float duracion, float intencidad)
    {
        Duracion = duracion;
        Intensidad = intencidad;

        StartCoroutine("Shake");

    }

    IEnumerator Shake()
    {
        float TiempoTranscurrido = 0;

        Vector3 PosInicial = transform.position;

        while (TiempoTranscurrido < Duracion)
        {
            TiempoTranscurrido += Time.deltaTime;

            float PPT = TiempoTranscurrido / Duracion;

            float compuerta = 1 - Mathf.Clamp(PPT * 4 - 3, 0f, 1f);

            float x = Random.Range(-1f, 1f) * compuerta * Intensidad;
            float y = Random.Range(-1f, 1f) * compuerta * Intensidad;
            float z = Random.Range(-1f, 1f) * compuerta * Intensidad;


            transform.position += new Vector3(x, y, z);

            yield return null;
        }

        transform.position = PosInicial;


    }

    void Update()
    {


        if (Size <= 10.6f && Puntaje.Escena != 2)
        {

            Camara.orthographicSize = 10.6f;

        }

        if (Size >= 18 && Puntaje.Escena == 2)
        {

            Camara.orthographicSize = 18;

        }

        if (Puntaje.Escena == 2 && Rotacion > 180)
        {
            if (Camara.orthographicSize < 18)
            {
               Size += 0.08f;
               Camara.orthographicSize = Size;
            }

            Debug.Log("Rotacion = " + Rotacion);
            Rotacion -= 1.5f;
            transform.rotation = Quaternion.Euler(0, 0, Rotacion);


        }

        if (Puntaje.Escena == 2 && Rotacion <= 180)
        {
            Rotacion = 180f;
            transform.rotation = Quaternion.Euler(0, 0, Rotacion);

        }

        if (Puntaje.Escena != 2 && Rotacion < 360)
        {
            if (Camara.orthographicSize > 10.6f)
            {
                Size -= 0.08f;
                Camara.orthographicSize = Size;
            }

            Debug.Log("Rotacion = " + Rotacion);
            Rotacion += 1.5f;
            transform.rotation = Quaternion.Euler(0, 0, Rotacion);


        }

        if (Puntaje.Escena != 2 && Rotacion >= 360)
        {
            Rotacion = 360f;
            transform.rotation = Quaternion.Euler(0, 0, Rotacion);

        }

    }
}
