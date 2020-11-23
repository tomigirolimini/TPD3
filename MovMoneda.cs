using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMoneda : MonoBehaviour
{
    public AudioClip moneda;
    AudioSource fuenteAudio;
    Renderer render;

    public GameObject Moneda;
    int velocidad = 6;
    public static float Dificultad = 1.4f;

    void Start()
    {

        render = GetComponent<Renderer>();
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = moneda;
    }

  
    void Update()
    {
        if (transform.position.y != 30)
        {
            transform.Translate(Vector3.down * Time.deltaTime * velocidad * Dificultad);
        }

        if (transform.position.y <= -17)
        {
            DestruirMoneda();
        }

    }

    void DestruirMoneda()
    {

        render.enabled = false;

        Destroy(Moneda,2);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Jugador")
        {
            fuenteAudio.Play();

            DestruirMoneda();
        }

    }
}
