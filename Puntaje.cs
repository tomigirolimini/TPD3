using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Puntaje : MonoBehaviour
{
    //SceneManager.LoadScene("Scene_Name");

    int tiempo = 0;
    float currentTime = 0;
    float maxTime = 1;

    bool CambioEs = false;

    public static int Nivel = 0;

    public static int Puntos = 0;
    public static int PuntosSig = 18;
    public Text Contador;

    public GameObject botonReiniciar;
    public static int Objetos;
    public static int ObjetosMax;


    public GameObject barco;

    AudioSource fuenteAudio;

    public static int objeto = 0;
    public static int Escena = 0;

    void Start()
    {
        Time.timeScale = 1;

        Objetos = 0;
        ObjetosMax = 4;

        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.Play();
        Nivel = 0;
    }


    void Update()
    {
        Debug.Log("Nivel: " + Nivel);
        if(barco == null)
        {
            Time.timeScale = 0;
            botonReiniciar.transform.position = new Vector3(350 , 650, 0);
            fuenteAudio.Stop();
            
        }

        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {

            currentTime = 0;

            tiempo++;

        }

        if (tiempo == 2)
        {
            tiempo = 0;

            Puntos++;

            Contador.text = Puntos.ToString();
        }
         
        if(Puntos > PuntosSig - 4 && CambioEs == false)
        {
            Nivel = -1;

            CambioEs = true;

            int EscenaActual = Escena;

            Escena = Random.Range(0,4);
     
           while(Escena == EscenaActual)
            {
                Escena = Random.Range(0, 4);
            }

            Debug.Log("Escena: " + Escena);
            
        }

        if(Puntos == PuntosSig)
        {
            CambioEs = false;
            PuntosSig += 10;
        }

    }

   public void ReiniciarNivel()
   {
        SwipeBarco.VidaF = 3.0f;
        Escena = 0;
        SwipeBarco.CantMonedas = 0;
        SwipeBarco.Vida = 3;
        CrearBalsaEnemiga.BalsaD = 0;
        CrearBalsaEnemiga.BalsaI = 0;
        MovMoneda.Dificultad = 1f;
        Nivel = 0;
        Puntos = 0;
        PuntosSig = 18;
        SwipeBarco.CantMonedas = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel1");

    }
}
