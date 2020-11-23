using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearObjetos : MonoBehaviour
{
    public GameObject Triangulo;
    public GameObject TrianguloRama;
    public GameObject Rama;
    public GameObject Piedra;
    public GameObject Moneda;


    float T;
    int T1 = 0;
    int MasterObject;
    int MasterObject2;
    //Variables para que aparezcan monedas
    int Monedas = 0;
    int B;


    //Variables para que aparezcan 2 objetos al mismo tiempo
    int DosObjetos = 0;
    int C;
    int LugObjeto;

    float currentTime = 0;
    int Tiempo;
    int Segundo = 1;
    int Lugar;

    int Cantidad;
    float Y = 14f;

    void Start()
    {
        B = Random.Range(1, 3);
        C = Random.Range(3, 7);
    }


    void Update()
    {
        if (Puntaje.Nivel == 0)
        {
            if (T1 == 1)
            {
                T += Time.deltaTime;

                if (T >= 1)
                {

                    T1 = 0;

                }

            }

            if (T >= 1)
            {
                switch (MasterObject2)
                {
                    case 2:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama2 = Instantiate(Rama, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), Quaternion.identity);
                        break;
                    case 3:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama3 = Instantiate(Rama, new Vector3(Random.Range(3f, 4f), 14, 0), Quaternion.identity);
                        break;
                    case 4:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra1 = Instantiate(Piedra, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), Quaternion.identity);
                        break;
                    case 5:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra2 = Instantiate(Piedra, new Vector3(Random.Range(3f, 4f), 14, 0), Quaternion.identity);
                        break;
                    case 7:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama4 = Instantiate(Rama, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), Quaternion.identity);
                        break;
                    case 8:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama5 = Instantiate(Rama, new Vector3(Random.Range(3f, 4f), 14, 0), Quaternion.identity);
                        break;
                    case 9:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra4 = Instantiate(Piedra, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), Quaternion.identity);
                        break;
                    case 10:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra5 = Instantiate(Piedra, new Vector3(Random.Range(3f, 4f), 14, 0), Quaternion.identity);
                        break;
                    case 12:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama7 = Instantiate(Rama, new Vector3(Random.Range(-4.3f, -3f), 14, 0), transform.rotation);
                        break;
                    case 13:
                        MasterObject2 = 0;
                        GameObject instanciaRama8 = Instantiate(Rama, new Vector3(Random.Range(3.7f, 4.3f), 14, 0), transform.rotation);
                        break;
                    case 14:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra6 = Instantiate(Piedra, new Vector3(Random.Range(-4.3f, -2.7f), 14, 0), transform.rotation);
                        break;
                    case 15:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra7 = Instantiate(Piedra, new Vector3(Random.Range(3.7f, 4.3f), 14, 0), transform.rotation);
                        break;
                    case 17:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama9 = Instantiate(Rama, new Vector3(Random.Range(-4.3f, -3f), 14, 0), transform.rotation);
                        break;
                    case 18:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama10 = Instantiate(Rama, new Vector3(Random.Range(3.7f, 4.3f), 14, 0), transform.rotation);
                        break;
                    case 19:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra9 = Instantiate(Piedra, new Vector3(Random.Range(-4.3f, -2.7f), 14, 0), transform.rotation);
                        break;
                    case 20:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra10 = Instantiate(Piedra, new Vector3(Random.Range(3.7f, 4.3f), 14, 0), transform.rotation);
                        break;
                    case 22:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama12 = Instantiate(Rama, new Vector3(Random.Range(-4.3f, -2.7f), 14, 0), transform.rotation);
                        break;
                    case 23:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama13 = Instantiate(Rama, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), transform.rotation);
                        break;
                    case 24:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra11 = Instantiate(Piedra, new Vector3(Random.Range(-4.3f, -2.7f), 14, 0), transform.rotation);
                        break;
                    case 25:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra12 = Instantiate(Piedra, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), transform.rotation);
                        break;
                    case 27:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama14 = Instantiate(Rama, new Vector3(Random.Range(-4.3f, -2.7f), 14, 0), transform.rotation);
                        break;
                    case 28:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaRama15 = Instantiate(Rama, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), transform.rotation);
                        break;
                    case 29:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra14 = Instantiate(Piedra, new Vector3(Random.Range(-4.3f, -2.7f), 14, 0), transform.rotation);
                        break;
                    case 30:
                        MasterObject2 = 0;
                        T = 0;
                        GameObject instanciaPiedra15 = Instantiate(Piedra, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), transform.rotation);
                        break;

                }

                switch (MasterObject)
                {
                    case 1:
                        MasterObject = 0;
                        T = 0;
                        GameObject instanciaRama1 = Instantiate(Rama, new Vector3(Random.Range(-4f, -3f), 14, 0), Quaternion.identity);
                        break;

                    case 6:
                        MasterObject = 0;
                        T = 0;
                        GameObject instanciaPiedra3 = Instantiate(Piedra, new Vector3(Random.Range(-4f, -3f), 14, 0), Quaternion.identity);
                        break;
                    case 11:
                        MasterObject = 0;
                        T = 0;
                        GameObject instanciaRama6 = Instantiate(Rama, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), Quaternion.identity);
                        break;
                    case 16:
                        MasterObject = 0;
                        T = 0;
                        GameObject instanciaPiedra8 = Instantiate(Piedra, new Vector3(Random.Range(-0.3f, 0.3f), 14, 0), transform.rotation);
                        break;
                    case 21:
                        MasterObject = 0;
                        T = 0;
                        GameObject instanciaRama11 = Instantiate(Rama, new Vector3(Random.Range(3.7f, 4.3f), 14, 0), transform.rotation);
                        break;
                    case 26:
                        MasterObject = 0;
                        T = 0;
                        GameObject instanciaPiedra13 = Instantiate(Piedra, new Vector3(Random.Range(3.7f, 4.3f), 14, 0), transform.rotation);
                        break;


                }
            }

            if (Puntaje.Nivel == 0)
            {

                currentTime += Time.deltaTime;

                if (currentTime >= Segundo)
                {
                    currentTime = 0;
                    Tiempo++;

                }

                if (Tiempo == Random.Range(2, 3) && Puntaje.Objetos < Puntaje.ObjetosMax)
                {

                    if (Puntaje.Objetos < Puntaje.ObjetosMax)
                    {
                        Puntaje.objeto = Random.Range(1, 3);

                        Tiempo = 0;
                        Lugar = Random.Range(0, 3);

                        if (Lugar == 0)
                        {
                            switch (Puntaje.objeto)
                            {

                                case 1:
                                    //1
                                    GameObject intanciaTriangulo = Instantiate(TrianguloRama, new Vector3(-4, 8, 0), Quaternion.identity);
                                    T1 = 1;
                                    MasterObject = 1;
                                    Puntaje.Objetos++;
                                    DosObjetos++;

                                    if (DosObjetos == C)
                                    {

                                        if (Puntaje.Objetos < Puntaje.ObjetosMax)
                                        {
                                            LugObjeto = Random.Range(1, 5);

                                            switch (LugObjeto)
                                            {
                                                case 1:
                                                    //2
                                                    GameObject intanciaTriangulo1 = Instantiate(TrianguloRama, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 2;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 2:
                                                    //3
                                                    GameObject intanciaTriangulo2 = Instantiate(TrianguloRama, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 3;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 3:
                                                    //4
                                                    GameObject intanciaTriangulo3 = Instantiate(Triangulo, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 4;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 4:
                                                    //5
                                                    GameObject intanciaTriangulo4 = Instantiate(Triangulo, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 5;
                                                    Puntaje.Objetos++;
                                                    break;
                                            }

                                            DosObjetos = 0;
                                            C = Random.Range(3, 7);
                                        }
                                        else
                                        {
                                            DosObjetos = 0;
                                        }

                                    }

                                    Monedas++;

                                    if (Monedas == B)
                                    {
                                        Cantidad = Random.Range(3, 6);

                                        int LugMonedas = Random.Range(1, 3);

                                        switch (LugMonedas)
                                        {
                                            case 1:
                                                LugMonedas = -4;
                                                break;
                                            case 2:
                                                LugMonedas = 0;
                                                break;
                                            case 3:
                                                LugMonedas = 4;
                                                break;
                                        }

                                        while (Cantidad != 0)
                                        {

                                            Y = Y + 2;
                                            GameObject instanciaMoneda1 = Instantiate(Moneda, new Vector3(LugMonedas, Y, 0), Quaternion.identity);
                                            Cantidad = Cantidad - 1;

                                        }

                                        Y = 14;
                                        Monedas = 0;
                                        B = Random.Range(1, 3);
                                    }

                                    break;

                                case 2:
                                    //6
                                    GameObject intanciaTriangulo5 = Instantiate(Triangulo, new Vector3(-4, 8, 0), Quaternion.identity);
                                    T1 = 1;
                                    MasterObject = 6;
                                    Puntaje.Objetos++;

                                    DosObjetos++;

                                    if (DosObjetos == C)
                                    {

                                        if (Puntaje.Objetos < Puntaje.ObjetosMax)
                                        {
                                            LugObjeto = Random.Range(1, 5);

                                            switch (LugObjeto)
                                            {
                                                case 1:
                                                    //7
                                                    GameObject intanciaTriangulo6 = Instantiate(TrianguloRama, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 7;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 2:
                                                    //8
                                                    GameObject intanciaTriangulo7 = Instantiate(TrianguloRama, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 8;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 3:
                                                    //9
                                                    GameObject intanciaTriangulo8 = Instantiate(Triangulo, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 9;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 4:
                                                    //10
                                                    GameObject intanciaTriangulo9 = Instantiate(Triangulo, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 10;
                                                    Puntaje.Objetos++;
                                                    break;
                                            }

                                            DosObjetos = 0;
                                            C = Random.Range(3, 7);
                                        }
                                        else
                                        {
                                            DosObjetos = 0;
                                        }

                                        Monedas++;

                                        if (Monedas == B)
                                        {
                                            Cantidad = Random.Range(3, 6);

                                            int LugMonedas = Random.Range(1, 3);

                                            switch (LugMonedas)
                                            {
                                                case 1:
                                                    LugMonedas = -4;
                                                    break;
                                                case 2:
                                                    LugMonedas = 0;
                                                    break;
                                                case 3:
                                                    LugMonedas = 4;
                                                    break;
                                            }

                                            while (Cantidad != 0)
                                            {

                                                Y = Y + 2;
                                                GameObject instanciaMoneda2 = Instantiate(Moneda, new Vector3(LugMonedas, Y, 0), Quaternion.identity);
                                                Cantidad = Cantidad - 1;

                                            }

                                            Y = 14;
                                            Monedas = 0;
                                            B = Random.Range(1, 3);
                                        }
                                    }

                                    break;
                            }

                        }

                        if (Lugar == 1)
                        {

                            switch (Puntaje.objeto)
                            {

                                case 1:
                                    //11
                                    GameObject intanciaTriangulo10 = Instantiate(TrianguloRama, new Vector3(0, 8, 0), Quaternion.identity);
                                    T1 = 1;
                                    MasterObject = 11;
                                    Puntaje.Objetos++;
                                    DosObjetos++;

                                    if (DosObjetos == C)
                                    {

                                        if (Puntaje.Objetos < Puntaje.ObjetosMax)
                                        {
                                            LugObjeto = Random.Range(1, 5);

                                            switch (LugObjeto)
                                            {
                                                case 1:
                                                    //12
                                                    GameObject intanciaTriangulo11 = Instantiate(TrianguloRama, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 12;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 2:
                                                    //13
                                                    GameObject intanciaTriangulo12 = Instantiate(TrianguloRama, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 13;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 3:
                                                    //14
                                                    GameObject intanciaTriangulo30 = Instantiate(Triangulo, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 14;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 4:
                                                    //15
                                                    GameObject intanciaTriangulo13 = Instantiate(Triangulo, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 15;
                                                    Puntaje.Objetos++;
                                                    break;
                                            }

                                            DosObjetos = 0;
                                            C = Random.Range(3, 7);
                                        }
                                        else
                                        {
                                            DosObjetos = 0;
                                        }

                                    }

                                    Monedas++;

                                    if (Monedas == B)
                                    {
                                        Cantidad = Random.Range(3, 6);

                                        int LugMonedas = Random.Range(1, 3);

                                        switch (LugMonedas)
                                        {
                                            case 1:
                                                LugMonedas = -4;
                                                break;
                                            case 2:
                                                LugMonedas = 0;
                                                break;
                                            case 3:
                                                LugMonedas = 4;
                                                break;
                                        }

                                        while (Cantidad != 0)
                                        {

                                            Y = Y + 2;
                                            GameObject instanciaMoneda3 = Instantiate(Moneda, new Vector3(LugMonedas, Y, 0), transform.rotation);
                                            Cantidad = Cantidad - 1;

                                        }

                                        Y = 14;
                                        Monedas = 0;
                                        B = Random.Range(1, 3);
                                    }

                                    break;


                                case 2:
                                    //16
                                    GameObject intanciaTriangulo14 = Instantiate(Triangulo, new Vector3(0, 8, 0), Quaternion.identity);
                                    T1 = 1;
                                    MasterObject = 16;
                                    Puntaje.Objetos++;

                                    DosObjetos++;

                                    if (DosObjetos == C)
                                    {

                                        if (Puntaje.Objetos < Puntaje.ObjetosMax)
                                        {
                                            LugObjeto = Random.Range(1, 5);

                                            switch (LugObjeto)
                                            {
                                                case 1:
                                                    //17
                                                    GameObject intanciaTriangulo15 = Instantiate(TrianguloRama, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 17;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 2:
                                                    //18
                                                    GameObject intanciaTriangulo16 = Instantiate(TrianguloRama, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 18;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 3:
                                                    //19
                                                    GameObject intanciaTriangulo17 = Instantiate(Triangulo, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 19;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 4:
                                                    //20
                                                    GameObject intanciaTriangulo18 = Instantiate(Triangulo, new Vector3(4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 20;
                                                    Puntaje.Objetos++;
                                                    break;
                                            }

                                            DosObjetos = 0;
                                            C = Random.Range(3, 7);
                                        }
                                        else
                                        {
                                            DosObjetos = 0;
                                        }

                                        Monedas++;

                                        if (Monedas == B)
                                        {
                                            Cantidad = Random.Range(3, 6);

                                            int LugMonedas = Random.Range(1, 3);

                                            switch (LugMonedas)
                                            {
                                                case 1:
                                                    LugMonedas = -4;
                                                    break;
                                                case 2:
                                                    LugMonedas = 0;
                                                    break;
                                                case 3:
                                                    LugMonedas = 4;
                                                    break;
                                            }

                                            while (Cantidad != 0)
                                            {

                                                Y = Y + 2;
                                                GameObject instanciaMOneda4 = Instantiate(Moneda, new Vector3(LugMonedas, Y, 0), transform.rotation);
                                                Cantidad = Cantidad - 1;

                                            }

                                            Y = 14;
                                            Monedas = 0;
                                            B = Random.Range(1, 3);
                                        }
                                    }
                                    break;
                            }
                        }

                        if (Lugar == 2)
                        {
                            switch (Puntaje.objeto)
                            {

                                case 1:
                                    //21
                                    GameObject intanciaTriangulo19 = Instantiate(TrianguloRama, new Vector3(4, 8, 0), Quaternion.identity);
                                    T1 = 1;
                                    MasterObject = 21;
                                    Puntaje.Objetos++;
                                    DosObjetos++;

                                    if (DosObjetos == C)
                                    {

                                        if (Puntaje.Objetos < Puntaje.ObjetosMax)
                                        {
                                            LugObjeto = Random.Range(1, 5);

                                            switch (LugObjeto)
                                            {
                                                case 1:
                                                    //22
                                                    GameObject intanciaTriangulo20 = Instantiate(TrianguloRama, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 22;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 2:
                                                    //23
                                                    GameObject intanciaTriangulo21 = Instantiate(TrianguloRama, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 23;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 3:
                                                    //24
                                                    GameObject intanciaTriangulo22 = Instantiate(Triangulo, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 24;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 4:
                                                    //25
                                                    GameObject intanciaTriangulo23 = Instantiate(Triangulo, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 25;
                                                    Puntaje.Objetos++;
                                                    break;
                                            }

                                            DosObjetos = 0;
                                            C = Random.Range(3, 7);
                                        }
                                        else
                                        {
                                            DosObjetos = 0;
                                        }

                                    }

                                    Monedas++;

                                    if (Monedas == B)
                                    {
                                        Cantidad = Random.Range(3, 6);

                                        int LugMonedas = Random.Range(1, 3);

                                        switch (LugMonedas)
                                        {
                                            case 1:
                                                LugMonedas = -4;
                                                break;
                                            case 2:
                                                LugMonedas = 0;
                                                break;
                                            case 3:
                                                LugMonedas = 4;
                                                break;
                                        }

                                        while (Cantidad != 0)
                                        {

                                            Y = Y + 2;
                                            GameObject instanciaMoneda5 = Instantiate(Moneda, new Vector3(LugMonedas, Y, 0), transform.rotation);
                                            Cantidad = Cantidad - 1;

                                        }

                                        Y = 14;
                                        Monedas = 0;
                                        B = Random.Range(1, 3);
                                    }

                                    break;


                                case 2:
                                    //26
                                    GameObject intanciaTriangulo24 = Instantiate(Triangulo, new Vector3(4, 8, 0), Quaternion.identity);
                                    T1 = 1;
                                    MasterObject = 26;
                                    Puntaje.Objetos++;

                                    DosObjetos++;

                                    if (DosObjetos == C)
                                    {

                                        if (Puntaje.Objetos < Puntaje.ObjetosMax)
                                        {
                                            LugObjeto = Random.Range(1, 5);

                                            switch (LugObjeto)
                                            {
                                                case 1:
                                                    //27
                                                    GameObject intanciaTriangulo25 = Instantiate(TrianguloRama, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 27;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 2:
                                                    //28
                                                    GameObject intanciaTriangulo26 = Instantiate(TrianguloRama, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 28;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 3:
                                                    //29
                                                    GameObject intanciaTriangulo27 = Instantiate(Triangulo, new Vector3(-4, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 29;
                                                    Puntaje.Objetos++;
                                                    break;

                                                case 4:
                                                    //30
                                                    GameObject intanciaTriangulo28 = Instantiate(Triangulo, new Vector3(0, 8, 0), Quaternion.identity);
                                                    T1 = 1;
                                                    MasterObject2 = 30;
                                                    Puntaje.Objetos++;
                                                    break;
                                            }

                                            DosObjetos = 0;
                                            C = Random.Range(3, 7);
                                        }
                                        else
                                        {
                                            DosObjetos = 0;
                                        }

                                        Monedas++;

                                        if (Monedas == B)
                                        {
                                            Cantidad = Random.Range(3, 6);

                                            int LugMonedas = Random.Range(1, 3);

                                            switch (LugMonedas)
                                            {
                                                case 1:
                                                    LugMonedas = -4;
                                                    break;
                                                case 2:
                                                    LugMonedas = 0;
                                                    break;
                                                case 3:
                                                    LugMonedas = 4;
                                                    break;
                                            }

                                            while (Cantidad != 0)
                                            {

                                                Y = Y + 2;
                                                GameObject instanciaMoneda6 = Instantiate(Moneda, new Vector3(LugMonedas, Y, 0), transform.rotation);
                                                Cantidad = Cantidad - 1;

                                            }

                                            Y = 14;
                                            Monedas = 0;
                                            B = Random.Range(1, 3);
                                        }
                                    }

                                    break;
                            }

                        }

                    }
                    else
                    {

                        Tiempo = 0;

                    }
                }

            }

        }
    }
}   
