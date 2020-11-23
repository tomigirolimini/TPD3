using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeBarcoN2 : MonoBehaviour
{
    Vector2 PosicionInicial;

    [SerializeField] public float SwipeMinX = 90;

    AudioSource fuenteAudio;
    public AudioClip barcoGolpeado;

    public static Vector3 pos;

    public GameObject Vida1;
    public GameObject Barco;
    public GameObject Moneda;

    public GameObject Disparo;
    public GameObject DisparoIzq;

    public Text Monedas;

    public GameObject Fuego;

    public static int Lug = 0;
    public static int PosX;
    public static int PosY = -3;

    bool Acomodar = false;

    bool Mover = false;

    int IzqDer = 0;
    int ArribAbajo = 0;

    void Start()
    {

        fuenteAudio = GetComponent<AudioSource>();

    }


    void Update()
    {
        pos = transform.position;

        if (Puntaje.Nivel == 1)
        {

            pos = transform.position;

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

                    if (swipeVertical > SwipeMinX && swipeHorizontal < swipeVertical)
                    {
                        float movV = Mathf.Sign(t.position.y - PosicionInicial.y);

                        if (movV > 0)
                        {
                            if (Acomodar == false)
                            {
                                transform.position = new Vector3(0, -1, 0);
                                Acomodar = true;
                            }

                            Mover = true;
                            ArribAbajo = 1;
                        }

                        if (movV < 0)
                        {
                            if (Acomodar == false)
                            {
                                transform.position = new Vector3(0, -1, 0);
                                Acomodar = true;
                            }

                            Mover = true;
                            ArribAbajo = -1;
                        }

                    }



                }

            }

            if (IzqDer == 1)
            {
                IzqDer = 0;

                switch (SwipeBarco.balasTotales)
                {

                    case 1:
                        if (SwipeBarco.balasCreadas <3)
                        {
                            SonidosSimples.sonidos = 1;
                            SwipeBarco.balasCreadas++;
                            GameObject Fuego1 = Instantiate(Fuego, new Vector3(transform.position.x + 0.48f, transform.position.y + 0.679f, 0), Quaternion.identity);
                            Fuego1.transform.Rotate(new Vector3(0, 0, -90));
                            GameObject instanciaDisparo1 = Instantiate(Disparo, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                            Fuego1.transform.parent = Barco.transform;
                            SwipeBarco.render.enabled = false;
                        }
                        break;
                    case 2:
                        switch (SwipeBarco.balasCreadas)
                        {
                            case 2:
                                if (SwipeBarco.balasCreadas <3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego2 = Instantiate(Fuego, new Vector3(transform.position.x + 0.48f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego2.transform.Rotate(new Vector3(0, 0, -90));
                                    GameObject instanciaDisparo2 = Instantiate(Disparo, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego2.transform.parent = Barco.transform;
                                    SwipeBarco.render1.enabled = false;
                                }
                                break;
                            case 1:
                                if (SwipeBarco.balasCreadas <3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego3 = Instantiate(Fuego, new Vector3(transform.position.x + 0.48f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego3.transform.Rotate(new Vector3(0, 0, -90));
                                    GameObject instanciaDisparo3 = Instantiate(Disparo, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego3.transform.parent = Barco.transform;
                                    SwipeBarco.render.enabled = false;
                                }
                                break;
                        }
                        break;
                    case 3:
                        switch (SwipeBarco.balasCreadas)
                        {
                            case 2:
                                if (SwipeBarco.balasCreadas <3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego4 = Instantiate(Fuego, new Vector3(transform.position.x + 0.48f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego4.transform.Rotate(new Vector3(0, 0, -90));
                                    GameObject instanciaDisparo4 = Instantiate(Disparo, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego4.transform.parent = Barco.transform;
                                    SwipeBarco.render2.enabled = false;
                                }
                                break;
                            case 1:
                                if (SwipeBarco.balasCreadas < 3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego5 = Instantiate(Fuego, new Vector3(transform.position.x + 0.48f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego5.transform.Rotate(new Vector3(0, 0, -90));
                                    GameObject instanciaDisparo5 = Instantiate(Disparo, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego5.transform.parent = Barco.transform;
                                    SwipeBarco.render1.enabled = false;
                                }
                                break;
                            case 0:
                                if (SwipeBarco.balasCreadas < 3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego6 = Instantiate(Fuego, new Vector3(transform.position.x + 0.48f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego6.transform.Rotate(new Vector3(0, 0, -90));
                                    GameObject instanciaDisparo6 = Instantiate(Disparo, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego6.transform.parent = Barco.transform;
                                    SwipeBarco.render.enabled = false;
                                }
                                break;
                        }
                        break;
                }



            }

            if (IzqDer == -1)
            {
                IzqDer = 0;

                switch (SwipeBarco.balasTotales)
                {

                    case 1:
                        if (SwipeBarco.balasCreadas < 3)
                        {
                            SonidosSimples.sonidos = 1;
                            SwipeBarco.balasCreadas++;
                            GameObject Fuego7 = Instantiate(Fuego, new Vector3(transform.position.x - 0.557f, transform.position.y + 0.679f, 0), Quaternion.identity);
                            Fuego7.transform.Rotate(new Vector3(0, 0, 90));
                            GameObject instanciaDisparo7 = Instantiate(DisparoIzq, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                            Fuego7.transform.parent = Barco.transform;
                            SwipeBarco.render.enabled = false;
                        }
                        break;
                    case 2:
                        switch (SwipeBarco.balasCreadas)
                        {
                            case 2:
                                if (SwipeBarco.balasCreadas < 3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego8 = Instantiate(Fuego, new Vector3(transform.position.x - 0.557f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego8.transform.Rotate(new Vector3(0, 0, 90));
                                    GameObject instanciaDisparo8 = Instantiate(DisparoIzq, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego8.transform.parent = Barco.transform;
                                    SwipeBarco.render1.enabled = false;
                                }
                                break;
                            case 1:
                                if (SwipeBarco.balasCreadas < 3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego9 = Instantiate(Fuego, new Vector3(transform.position.x - 0.557f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego9.transform.Rotate(new Vector3(0, 0, 90));
                                    GameObject instanciaDisparo9 = Instantiate(DisparoIzq, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego9.transform.parent = Barco.transform;
                                    SwipeBarco.render.enabled = false;
                                }
                                break;
                        }
                        break;
                    case 3:
                        switch (SwipeBarco.balasCreadas)
                        {
                            case 2:
                                if (SwipeBarco.balasCreadas < 3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego10 = Instantiate(Fuego, new Vector3(transform.position.x - 0.557f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego10.transform.Rotate(new Vector3(0, 0, 90));
                                    GameObject instanciaDisparo10 = Instantiate(DisparoIzq, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego10.transform.parent = Barco.transform;
                                    SwipeBarco.render2.enabled = false;
                                }
                                break;
                            case 1:
                                if (SwipeBarco.balasCreadas < 3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego11 = Instantiate(Fuego, new Vector3(transform.position.x - 0.557f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego11.transform.Rotate(new Vector3(0, 0, 90));
                                    GameObject instanciaDisparo11 = Instantiate(DisparoIzq, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego11.transform.parent = Barco.transform;
                                    SwipeBarco.render1.enabled = false;
                                }
                                break;
                            case 0:
                                if (SwipeBarco.balasCreadas < 3)
                                {
                                    SonidosSimples.sonidos = 1;
                                    SwipeBarco.balasCreadas++;
                                    GameObject Fuego12 = Instantiate(Fuego, new Vector3(transform.position.x - 0.557f, transform.position.y + 0.679f, 0), Quaternion.identity);
                                    Fuego12.transform.Rotate(new Vector3(0, 0, 90));
                                    GameObject instanciaDisparo12 = Instantiate(DisparoIzq, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity);
                                    Fuego12.transform.parent = Barco.transform;
                                    SwipeBarco.render.enabled = false;
                                }
                                break;
                        }
                        break;
                }



            }

            if (Lug == 0 && Mover == true && ArribAbajo == 1)
            {


                if (transform.position.y < 5)
                {

                    transform.Translate(new Vector3(0, 1, 0));
                }

                if (transform.position.y >= 5)
                {

                    Lug = -1;
                    ArribAbajo = 0;
                    Mover = false;
                }

            }

            if (Lug == 1 && Mover == true && ArribAbajo == 1)
            {

                if (transform.position.y < -1)
                {

                    transform.Translate(new Vector3(0, 1, 0));
                }

                if (transform.position.y >= -1)
                {

                    Lug = 0;
                    ArribAbajo = 0;
                    Mover = false;
                }


            }

            if (Lug == 0 && Mover == true && ArribAbajo == -1)
            {

                if (transform.position.y > -7)
                {

                    transform.Translate(new Vector3(0, -1, 0));
                }

                if (transform.position.y <= -7)
                {

                    Lug = 1;
                    ArribAbajo = 0;
                    Mover = false;
                }

            }

            if (Lug == -1 && Mover == true && ArribAbajo == -1)
            {

                if (transform.position.y > -1)
                {

                    transform.Translate(new Vector3(0, -1, 0));
                }

                if (transform.position.y <= -1)
                {

                    Lug = 0;
                    ArribAbajo = 0;
                    Mover = false;
                }

            }


        }

    }
}
