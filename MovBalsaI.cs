using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBalsaI : MonoBehaviour
{
    public GameObject Moneda;
    public GameObject DisparoD;

    bool Mover1 = false;
    int LugarI;

    bool Comienzo = false;
    bool aTodos = false;

    int tiempo = 0;
    float currentTime = 0;
    float maxTime = 1;

    bool ReactivarTiempo = false;

    bool TempoAct = false;
    int Tempo;
    int AoA;

   bool Irse = false;

    int ParaDisparo;
    int Disparo = 0;
    bool Disparando = false;

    void Start()
    {
        LugarI = CrearBalsaEnemiga.LugI;
        ParaDisparo = Random.Range(1, 4);
    }


    void Update()
    {

        if (ParaDisparo == Disparo)
        {
            if (ReactivarTiempo == false)
            {
                tiempo = 0;
                ReactivarTiempo = true;
            }

            Disparando = true;

            if (tiempo >= 1)
            {
                ParaDisparo = Random.Range(1, 4);
                Disparo = 0;
                SonidosSimples.sonidos = 1;
                GameObject instanciaDisparoE = Instantiate(DisparoD, new Vector3(transform.position.x - 0.4f, transform.position.y, 0), Quaternion.identity);
                tiempo = 0;
                Disparando = false;
                ReactivarTiempo = false;
            }

        }


        if (Comienzo == true)
        {
            currentTime += Time.deltaTime;
        }

        if (currentTime >= maxTime && Comienzo == true)
        {

            currentTime = 0;

            tiempo++;

 
        }

        if (TempoAct == false && Disparando == false)
        {
            TempoAct = true;
            Tempo = Random.Range(0, 3);

        }

        if (tiempo == Tempo && Disparando == false)
        {
            Mover1 = true;

        }

        if (tiempo >= Tempo && Mover1 == true && Disparando == false && Puntaje.Nivel == 1 && Irse == false)
        {


            switch (LugarI)
            {
                case 1:

                    Mover1 = true;

                    if (transform.position.y > -0.6f)
                    {

                        transform.Translate(new Vector3(0, -1 * Time.deltaTime * 10, 0));
                    }

                    if (transform.position.y <= -0.6f)
                    {
                        Disparo++;
                        transform.position = new Vector3(-4, -0.6f, 0);
                        tiempo = 0;
                        LugarI = 2;
                        Mover1 = false;
                        TempoAct = false;
                    }
                    break;

                case 2:

                    if (aTodos == false)
                    {
                        aTodos = true;
                        AoA = Random.Range(1, 3);
                    }

                    switch (AoA)
                    {
                        case 1:
                            Mover1 = true;

                            if (transform.position.y < 5.4f)
                            {

                                transform.Translate(new Vector3(0, 1 * Time.deltaTime * 10, 0));
                            }

                            if (transform.position.y >= 5.4f)
                            {
                                Disparo++;
                                transform.position = new Vector3(-4, 5.4f, 0);
                                tiempo = 0;
                                LugarI = 1;
                                Mover1 = false;
                                aTodos = false;
                                TempoAct = false;
                            }
                            break;


                        case 2:
                            Mover1 = true;

                            if (transform.position.y > -6.6f)
                            {

                                transform.Translate(new Vector3(0, -1 * Time.deltaTime * 10, 0));
                            }

                            if (transform.position.y <= -6.6f)
                            {
                                Disparo++;
                                transform.position = new Vector3(-4, -6.6f, 0);
                                tiempo = 0;
                                LugarI = 3;
                                Mover1 = false;
                                aTodos = false;
                                TempoAct = false;
                            }
                            break;


                    }

                    break;

                case 3:

                    Mover1 = true;

                    if (transform.position.y < -0.6f)
                    {

                        transform.Translate(new Vector3(0, 1 * Time.deltaTime * 10, 0));
                    }

                    if (transform.position.y >= -0.6f)
                    {
                        Disparo++;
                        transform.position = new Vector3(-4, -0.6f, 0);
                        tiempo = 0;
                        LugarI = 2;
                        Mover1 = false;
                        TempoAct = false;
                    }
                    break;

            }

        }

        if (Comienzo == false)
        {

            switch (LugarI)
            {
                case (1):
                    if (transform.position.x <= -4 && transform.position.y <= 5.6f)
                    {
                        transform.Translate(new Vector3(0.1f, 0.1f, 0));

                    }

                    if (transform.position.x >= -4 || transform.position.y >= 5.6f)
                    {

                        transform.position = new Vector3(-4, 5.6f, 0);
                        Comienzo = true;
                    }
                    break;

                case (2):
                    if (transform.position.x < -4 && transform.position.y < -0.6f)
                    {
                        transform.Translate(new Vector3(0.1f, 0.1f, 0));

                    }

                    if (transform.position.x >= -4 || transform.position.y >= -0.6f)
                    {

                        transform.position = new Vector3(-4, -0.6f, 0);
                        Comienzo = true;
                    }
                    break;

                case (3):
                    if (transform.position.x < -4 && transform.position.y < -6.6f)
                    {
                        transform.Translate(new Vector3(0.1f, 0.1f, 0));

                    }

                    if (transform.position.x >= -4 || transform.position.y >= -6.6f)
                    {

                        transform.position = new Vector3(-4, -6.6f, 0);
                        Comienzo = true;
                    }
                    break;

            }

        }

        if (Puntaje.Escena != 1)
        {
            CrearBalsaEnemiga.BalsaI = 0;
            Irse = true;
            float fixedspeed = 1 * Time.deltaTime * 6;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-30, 15, 0), fixedspeed);
        }

        if (transform.position.x < -29 && transform.position.y < 14)
        {
            
            Destroy(gameObject);

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Disparo" && Puntaje.Nivel == 1)
        {
            Destroy(gameObject);

            int NumeroR = Random.Range(3, 5);

            while (NumeroR > 0)
            {

                float Xr = Random.Range(-1.0f, 2.0f);
                float Yr = Random.Range(-1.0f, 2.0f);

                GameObject instanciaMoneda = Instantiate(Moneda, new Vector3(transform.position.x + Xr, transform.position.y + Yr, 0), Quaternion.identity);

                NumeroR = NumeroR - 1;

            }

            CrearBalsaEnemiga.BalsaI = 0;


        }

    }





}
