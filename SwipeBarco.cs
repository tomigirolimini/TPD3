using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeBarco : MonoBehaviour
{
    public CamaraShake C;

    Animator animator;

    Vector2 PosicionInicial;

    [SerializeField] public float SwipeMinX = 90;

    AudioSource fuenteAudio;
    public AudioClip barcoGolpeado;

    public GameObject Fuego;
    public GameObject Vida1;
    public GameObject Barco;
    public GameObject Moneda;
    public GameObject Disparo;

    public GameObject Disparo1;
    public GameObject Disparo2;
    public GameObject Disparo3;

    public static float VidaF = 3.0f;

    public static Renderer render;
    public static Renderer render1;
    public static Renderer render2;

    public static int balasTotales = 3;
    public static int balasCreadas = 0;

    public Text Monedas;

    public static int CantMonedas;

    public static int Lug = 0;
    public static int PosX;
    public static int PosY = -3;

    bool Mover = false;
    int IzqDer = 0;

   public static int Vida = 3;

    bool Inmunidad = false;

    void Start()
    {
        balasCreadas = 0;

        fuenteAudio = GetComponent<AudioSource>();

        animator = GetComponent<Animator>(); 

        render  = Disparo1.GetComponent<Renderer>();
        render1 = Disparo2.GetComponent<Renderer>();
        render2 = Disparo3.GetComponent<Renderer>();

        render.enabled = false;
        render1.enabled = false;
        render2.enabled = false;

        switch(balasTotales)
        {

            case 1:
                render.enabled = true;
                break;
            case 2:
                render.enabled = true;
                render1.enabled = true;
                break;
            case 3:
                render.enabled = true;
                render1.enabled = true;
                render2.enabled = true;
                break;
        }
       
    }


    void Update()
    {

        if (Puntaje.Nivel == 0)
        {
            if (Input.touchCount > 0)
            {
                Touch t = Input.GetTouch(0);

                if (t.phase == TouchPhase.Began)
                {
                    PosicionInicial = t.position;
                }
                else if (t.phase == TouchPhase.Ended)
                {

                    float swipeHorizontal = (new Vector3(t.position.x, 0, 0) - new Vector3(PosicionInicial.x, 0, 0)).magnitude;
                    float swipeVertical = (new Vector3(0, t.position.y, 0) - new Vector3(0, PosicionInicial.y, 0)).magnitude;

                    if (swipeHorizontal > SwipeMinX && swipeHorizontal > swipeVertical)
                    {
                        float mov = Mathf.Sign(t.position.x - PosicionInicial.x);

                        if (mov > 0)
                        {
                            Mover = true;
                            IzqDer = 1;
                        }

                        if (mov < 0)
                        {
                            Mover = true;
                            IzqDer = -1;
                        }

                    }

                    if (swipeVertical > SwipeMinX && swipeVertical > 0 && balasCreadas < balasTotales && swipeVertical > swipeHorizontal)
                    {

                        switch (balasTotales)
                        {

                            case 1:
                                SonidosSimples.sonidos = 1;
                                balasCreadas++;
                                GameObject Fuego1 = Instantiate(Fuego, new Vector3(transform.position.x - 0.042f, transform.position.y + 1.513f, 0), Quaternion.identity);
                                GameObject instanciaDisparo1 = Instantiate(Disparo, new Vector3(transform.position.x,-1.7f , 0), Quaternion.identity);
                                Fuego1.transform.parent = Barco.transform;
                                render.enabled = false;
                                break;
                            case 2:
                                switch (balasCreadas)
                                {
                                    case 2:
                                        SonidosSimples.sonidos = 1;
                                        balasCreadas++;
                                        GameObject Fuego2 = Instantiate(Fuego, new Vector3(transform.position.x - 0.042f, transform.position.y + 1.513f, 0), Quaternion.identity);
                                        GameObject instanciaDisparo2 = Instantiate(Disparo, new Vector3(transform.position.x, -1.7f, 0), Quaternion.identity);
                                        Fuego2.transform.parent = Barco.transform;
                                        render1.enabled = false;
                                        break;
                                    case 1:
                                        SonidosSimples.sonidos = 1;
                                        balasCreadas++;
                                        GameObject Fuego3 = Instantiate(Fuego, new Vector3(transform.position.x - 0.042f, transform.position.y + 1.513f, 0), Quaternion.identity);
                                        GameObject instanciaDisparo3 = Instantiate(Disparo, new Vector3(transform.position.x, -1.7f, 0), Quaternion.identity);
                                        Fuego3.transform.parent = Barco.transform;
                                        render.enabled = false;
                                        break;
                                }
                                break;
                            case 3:
                                switch (balasCreadas)
                                {
                                    case 2:
                                        SonidosSimples.sonidos = 1;
                                        balasCreadas++;
                                        GameObject Fuego4 = Instantiate(Fuego, new Vector3(transform.position.x - 0.042f, transform.position.y + 1.513f, 0), Quaternion.identity);
                                        GameObject instanciaDisparo4 = Instantiate(Disparo, new Vector3(transform.position.x, -1.7f, 0), Quaternion.identity);
                                        Fuego4.transform.parent = Barco.transform;
                                        render2.enabled = false;
                                        break;
                                    case 1:
                                        SonidosSimples.sonidos = 1;
                                        balasCreadas++;
                                        GameObject Fuego5 = Instantiate(Fuego, new Vector3(transform.position.x - 0.042f, transform.position.y + 1.513f, 0), Quaternion.identity);
                                        GameObject instanciaDisparo5 = Instantiate(Disparo, new Vector3(transform.position.x, -1.7f, 0), Quaternion.identity);
                                        Fuego5.transform.parent = Barco.transform;
                                        render1.enabled = false;
                                        break;
                                    case 0:
                                        SonidosSimples.sonidos = 1;
                                        balasCreadas++;
                                        GameObject Fuego6 = Instantiate(Fuego, new Vector3(transform.position.x - 0.042f, transform.position.y + 1.513f, 0), Quaternion.identity);
                                        GameObject instanciaDisparo6 = Instantiate(Disparo, new Vector3(transform.position.x, -1.7f, 0), Quaternion.identity);
                                        Fuego6.transform.parent = Barco.transform;
                                        render.enabled = false;
                                        break;
                                }
                                break;
                        }


                    }

                }

            }

            if (Lug == 0 && Mover == true && IzqDer == -1)
            {

               

                if (transform.position.x > -4)
                {

                    transform.Translate(new Vector3(-0.5f, 0, 0));
                }

                if (transform.position.x <= -4)
                {
              
                    Lug = -1;
                    IzqDer = 0;
                    Mover = false;
                }

            }

            if (Lug == 1 && Mover == true && IzqDer == -1)
            {
         

                if (transform.position.x > 0)
                {

                    transform.Translate(new Vector3(-0.5f, 0, 0));
                }

                if (transform.position.x <= 0)
                {
                 
                    Lug = 0;
                    IzqDer = 0;
                    Mover = false;
                }


            }

            if (Lug == 0 && Mover == true && IzqDer == 1)
            {
          
                if (transform.position.x < 4)
                {

                    transform.Translate(new Vector3(0.5f, 0, 0));
                }

                if (transform.position.x >= 4)
                {
            
                    Lug = 1;
                    IzqDer = 0;
                    Mover = false;
                }

            }

            if (Lug == -1 && Mover == true && IzqDer == 1)
            {
             
                if (transform.position.x < 0)
                {

                    transform.Translate(new Vector3(0.5f, 0, 0));
                }

                if (transform.position.x >= 0)
                {
                  
                    Lug = 0;
                    IzqDer = 0;
                    Mover = false;
                }

            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Puntaje.Escena == 0)
        {
            if (other.tag == "Tronco")
            {
                C.shake(0.05f, 0.5f);

                PerderVida();
            }

            if (other.tag == "Piedra")
            {
                C.shake(0.05f, 0.5f);

                SonidosSimples.sonidos = 4;
                PerderVida();
            }

            if (other.tag == "Bala")
            {
                C.shake(0.05f, 0.5f);

                SonidosSimples.sonidos = 4;
                PerderVida();
            }

        }

        if (other.tag == "DisparoEnemigo")
        {
           C.shake(0.05f, 0.5f);

           SonidosSimples.sonidos = 4;
           PerderVida();
        }

        if (other.tag == "Moneda")
        {
            SumarMoneda();
        }

    }

    void SumarMoneda()
    {
        CantMonedas++;
        Monedas.text = CantMonedas.ToString();

    }

    void PerderVida()
    {

        if (Vida == 3 && Inmunidad == false)
        {

             VidaF = 2.1f;

             Vida = 2;

            Inmunidad = true;

        }

        if (Vida == 2 && Inmunidad == false)
        {

            VidaF = 1.1f;

            Vida = 1;

            Inmunidad = true;

        }

        if (Vida == 1 && Inmunidad == false)
        {
            C.shake(0f, 0f);

            Destroy(Barco);


        }

        Inmunidad = false;
    }

}
