using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{

    bool Activar = false;

    public GameObject BombaCae;

    public AudioClip disparo;
    public AudioClip balaAgua;

    AudioSource fuenteAudio;

    Renderer render;
   

    void Start()
    {
        render = GetComponent<Renderer>();
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = disparo;
        fuenteAudio.Play();

    }

    public GameObject Bala;

    void Update()
    {
        
        if (transform.position.y <= -3 || transform.position.x != 10 || transform.localScale.x > 1)
        {
           
            if(transform.position.z == 5)
            {
                if (transform.position.y < -3)
                {
                    transform.Translate(new Vector3(0, 9, 0) * Time.deltaTime / 2.5f);

                }

                if (transform.position.y >= -6)
                {
                    transform.localScale += new Vector3(-0.01F, -0.01f, 0);

                }

                if (transform.localScale.x >= 0.3f && transform.position.y < -3)
                {
                    transform.localScale += new Vector3(-0.001F, -0.001f, 0);
                }
            }

            if (transform.position.z == 5.1f)
            {
                if (transform.position.y < -3)
                {
                    transform.Translate(new Vector3(-4, 9, 0) * Time.deltaTime / 2.5f);
                }

                if (transform.position.y >= -6)
                {
                    transform.localScale += new Vector3(-0.01F, -0.01f, 0);

                }

                if (transform.localScale.x >= 0.3f && transform.position.y < -3)
                {
                    transform.localScale += new Vector3(-0.001F, -0.001f, 0);
                }

            }

            if (transform.position.z == 5.2f)
            {
                if (transform.position.y < -3)
                {
                    transform.Translate(new Vector3(4, 9, 0) * Time.deltaTime / 2.5f);

                }

                if (transform.position.y >= -6)
                {
                    transform.localScale += new Vector3(-0.01F, -0.01f, 0);

                }

                if (transform.localScale.x >= 0.3f && transform.position.y < -3)
                {
                    transform.localScale += new Vector3(-0.001F, -0.001f, 0);
                }

            }

        }


        if (transform.localScale.x <= 0.4f && Activar == false)
        {
            Activar = true;
            SonidosSimples.sonidos = 5;

            GameObject instanciaBalaCae = Instantiate(BombaCae, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            DestruirBala();
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Jugador" && Activar == false)
        {
            Activar = true;

            DestruirBala();

        }

    }

    void DestruirBala()
    {
        render.enabled = false;
        Destroy(Bala);
    }

}
