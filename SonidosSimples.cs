using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosSimples : MonoBehaviour
{
    public static int sonidos;

    public AudioClip disparo;
    public AudioClip DisparoAgua;
    public AudioClip DisparoTronco;
    public AudioClip BarcoRompiendose;
    public AudioClip BalaenAgua;

    AudioSource fuenteAudio;
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

  
    void Update()
    {
        switch (sonidos)
        {
            //disparo jugador
            case 1:
                sonidos = 0;
                fuenteAudio.clip = disparo;
                fuenteAudio.Play();
                break;
            //disparo agua
            case 2:
                sonidos = 0;
                fuenteAudio.clip = DisparoAgua;
                fuenteAudio.Play();
                break;
            //disparo tronco
            case 3:
                sonidos = 0;
                fuenteAudio.clip = DisparoTronco;
                fuenteAudio.Play();
                break;
            // golpe de barco a tronco
            case 4:
                sonidos = 0;
                fuenteAudio.clip = BarcoRompiendose;
                fuenteAudio.Play();
                break;
            // golpe de bala al agua
            case 5:
                sonidos = 0;
                fuenteAudio.clip = BalaenAgua;
                fuenteAudio.Play();
                break;
        }
    }
}
