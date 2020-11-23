using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{
    public GameObject BarcoEnemigo;
    public GameObject BarcoJugador;
    public GameObject Vida1;
    public GameObject Disparo1;
    public GameObject Disparo2;
    public GameObject Disparo3;
    public GameObject MonedaUI;


    public static int DisparoN;


    void Start()
    {

    }

 
    void Update()
    {
        if(Puntaje.Escena == 0)
        {

            if (BarcoEnemigo.transform.position.y < -9)
            {
                Vector3 final = new Vector3(0, -9, 0);
                BarcoEnemigo.transform.position = Vector3.MoveTowards(BarcoEnemigo.transform.position, final, 1 * Time.deltaTime * 5);

            }
          
        }
        else
        {
            
          
            if (Puntaje.Escena == 1 || Puntaje.Escena == 2 || Puntaje.Escena == 3)
            {
                if (BarcoEnemigo.transform.position.y > -12)
                {
                    Vector3 final = new Vector3(0, -12, 0);
                    BarcoEnemigo.transform.position = Vector3.MoveTowards(BarcoEnemigo.transform.position, final, 1 * Time.deltaTime * 5);


                }
            }
        }

        if ((Puntaje.Puntos >= Puntaje.PuntosSig - 4 || Puntaje.Puntos <= Puntaje.PuntosSig - 18) && Puntaje.Escena == 3)
        {
            Vida1.transform.localScale = new Vector3(1, 1, 1);

            Vida1.transform.position = new Vector3(4, 8.5f, 7);

            Vida1.transform.eulerAngles = new Vector3(0, 0, 360);

            Disparo1.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            Disparo2.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            Disparo3.transform.localScale = new Vector3(0.6f, 0.6f, 1);

            Disparo1.transform.position = new Vector3(-4.84f, -6, 1);
            Disparo2.transform.position = new Vector3(-4.84f, -7, 1);
            Disparo3.transform.position = new Vector3(-4.84f, -8, 1);

            MonedaUI.transform.localScale = new Vector3(2, 2, 1);
            MonedaUI.transform.position = new Vector3(-4.5f, 5.2f, 1);


            if ((BarcoJugador.transform.position.y != 0 || BarcoJugador.transform.position.x != 0) && Puntaje.Nivel == -1 && Puntaje.Escena == 3)
            {
                float fixedspeed = 1 * Time.deltaTime * 2;
                BarcoJugador.transform.position = Vector3.MoveTowards(BarcoJugador.transform.position, new Vector3(0, 0, 0), fixedspeed);
            }

            if (BarcoJugador.transform.position.y == 0 && BarcoJugador.transform.position.x == 0 && Puntaje.Escena == 3)
            {
     
                SwipeBarco.render.enabled = false;
                SwipeBarco.render1.enabled = false;
                SwipeBarco.render2.enabled = false;

                Puntaje.Nivel = 3;

            }

        }

        if ((Puntaje.Puntos >= Puntaje.PuntosSig - 4 || Puntaje.Puntos <= Puntaje.PuntosSig - 18) && Puntaje.Escena == 1)
        {
            Vida1.transform.localScale = new Vector3(1, 1, 1);

            Vida1.transform.position = new Vector3(4, 8.5f, 7);
  
            Vida1.transform.eulerAngles = new Vector3(0, 0, 360);

            Disparo1.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            Disparo2.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            Disparo3.transform.localScale = new Vector3(0.6f, 0.6f, 1);

            Disparo1.transform.position = new Vector3(-4.84f, -6, 1);
            Disparo2.transform.position = new Vector3(-4.84f, -7, 1);
            Disparo3.transform.position = new Vector3(-4.84f, -8, 1);

            MonedaUI.transform.localScale = new Vector3(2, 2, 1);
            MonedaUI.transform.position = new Vector3(-4.5f, 5.2f, 1);

            if ((BarcoJugador.transform.position.y != -1 || BarcoJugador.transform.position.x != 0) && Puntaje.Nivel == -1 && Puntaje.Escena == 1)
            {
                float fixedspeed = 1 * Time.deltaTime * 2;
                BarcoJugador.transform.position = Vector3.MoveTowards(BarcoJugador.transform.position,new Vector3(0,-1,0), fixedspeed);
            }

            if (BarcoJugador.transform.position.y == -1 && BarcoJugador.transform.position.x == 0 && Puntaje.Escena == 1)
            {
                switch (SwipeBarco.balasCreadas)
                {
                    case 0:
                        SwipeBarco.render.enabled = true;
                        SwipeBarco.render1.enabled = true;
                        SwipeBarco.render2.enabled = true;
                        break;

                    case 1:
                        SwipeBarco.render1.enabled = true;
                        SwipeBarco.render2.enabled = true;
                        break;
                    case 2:
                        SwipeBarco.render2.enabled = true;
                        break;

                }

                DisparoN = 1;
                Puntaje.Nivel = 1;
           
            }

        }


        if ((Puntaje.Puntos >= Puntaje.PuntosSig - 4 || Puntaje.Puntos <= Puntaje.PuntosSig - 18) && Puntaje.Escena == 0)
        {
            Vida1.transform.localScale = new Vector3(1, 1, 1);

            Vida1.transform.position = new Vector3(4, 8.5f, 7);

            Vida1.transform.eulerAngles = new Vector3(0, 0, 360);

            Disparo1.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            Disparo2.transform.localScale = new Vector3(0.6f, 0.6f, 1);
            Disparo3.transform.localScale = new Vector3(0.6f, 0.6f, 1);

            Disparo1.transform.position = new Vector3(-4.84f, -6, 1);
            Disparo2.transform.position = new Vector3(-4.84f, -7, 1);
            Disparo3.transform.position = new Vector3(-4.84f, -8, 1);

            MonedaUI.transform.localScale = new Vector3(2, 2, 1);
            MonedaUI.transform.position = new Vector3(-4.5f, 5.2f, 1);

            if ((BarcoJugador.transform.position.y != -3 || BarcoJugador.transform.position.x != 0) && Puntaje.Nivel == -1 && Puntaje.Escena == 0)
            {
                float fixedspeed = 1 * Time.deltaTime * 2;
                BarcoJugador.transform.position = Vector3.MoveTowards(BarcoJugador.transform.position, new Vector3(0, -3, 0), fixedspeed);
            }

            if (BarcoJugador.transform.position.y == -3 && BarcoJugador.transform.position.x == 0 && Puntaje.Escena == 0)
            {
                switch (SwipeBarco.balasCreadas)
                {
                    case 0:
                        SwipeBarco.render.enabled = true;
                        SwipeBarco.render1.enabled = true;
                        SwipeBarco.render2.enabled = true;
                        break;

                    case 1:
                        SwipeBarco.render1.enabled = true;
                        SwipeBarco.render2.enabled = true;
                        break;
                    case 2:
                        SwipeBarco.render2.enabled = true;
                        break;

                }
                DisparoN = 0;
                Puntaje.Nivel = 0;

            }

        }

        if ((Puntaje.Puntos >= Puntaje.PuntosSig - 4 || Puntaje.Puntos <= Puntaje.PuntosSig - 18) && Puntaje.Escena == 2)
        {
            Vida1.transform.localScale = new Vector3(1.41f, 1.41f, 1);

            Vida1.transform.position = new Vector3(-7,-14.7f,7);
 
            Vida1.transform.eulerAngles = new Vector3(0, 0, 180);

            Disparo1.transform.localScale = new Vector3(1, 1, 1);
            Disparo2.transform.localScale = new Vector3(1, 1, 1);
            Disparo3.transform.localScale = new Vector3(1, 1, 1);

            Disparo1.transform.position = new Vector3(8.5f, 11, 1);
            Disparo2.transform.position = new Vector3(8.5f, 12.7f, 1);
            Disparo3.transform.position = new Vector3(8.5f, 14.4f, 1);

            MonedaUI.transform.localScale = new Vector3(2.82f, 2.82f, 1);
            MonedaUI.transform.position = new Vector3(8, -22.5f, 1);

            if ((BarcoJugador.transform.position.y != 0 || BarcoJugador.transform.position.x != 0) && Puntaje.Nivel == -1)
            {
                float fixedspeed = 1 * Time.deltaTime * 2;
                BarcoJugador.transform.position = Vector3.MoveTowards(BarcoJugador.transform.position, new Vector3(0, 0, 0), fixedspeed);
            }

            if (BarcoJugador.transform.position.x == 0 && BarcoJugador.transform.position.y == 0)
            {
                switch (SwipeBarco.balasCreadas)
                {
                    case 0:
                        SwipeBarco.render.enabled = true;
                        SwipeBarco.render1.enabled = true;
                        SwipeBarco.render2.enabled = true;
                        break;

                    case 1:
                        SwipeBarco.render1.enabled = true;
                        SwipeBarco.render2.enabled = true;
                        break;
                    case 2:
                        SwipeBarco.render2.enabled = true;
                        break;

                }
                DisparoN = 2;
                Puntaje.Nivel = 2;
            }
        }

    }
}
