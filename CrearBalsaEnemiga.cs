using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearBalsaEnemiga : MonoBehaviour
{
    public GameObject BalsaEnemigaD;
    public GameObject BalsaEnemigaI;
    public GameObject BalsaEnemigaA;

    public GameObject Estela;

    public static int BalsaD = 0;
    public static int BalsaI = 0;
    public static int BalsaA = 0;


    public static int LugD;
    public static int LugA;
    public static int LugI;

    void Start()
    {
        
      

    }


    void Update()
    {
        if (Puntaje.Nivel == 1 )
        {
            if (BalsaD == 0)
            {
                LugD = Random.Range(1, 4);

                BalsaD++;

                switch (LugD)
                {
                    case 1:
                        GameObject BalsaD1 = Instantiate(BalsaEnemigaD, new Vector3(8, 1.4f, 0), Quaternion.identity);
                        GameObject Estela1 = Instantiate(Estela, new Vector3(BalsaD1.transform.position.x, BalsaD1.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela1.transform.parent = BalsaD1.transform;
                        break;

                    case 2:
                        GameObject BalsaD2 = Instantiate(BalsaEnemigaD, new Vector3(8, -4.6f, 0), Quaternion.identity);
                        GameObject Estela2 = Instantiate(Estela, new Vector3(BalsaD2.transform.position.x, BalsaD2.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela2.transform.parent = BalsaD2.transform;
                        break;

                    case 3:
                        GameObject BalsaD3 = Instantiate(BalsaEnemigaD, new Vector3(8, -10.6f, 0), Quaternion.identity);
                        GameObject Estela3 = Instantiate(Estela, new Vector3(BalsaD3.transform.position.x, BalsaD3.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela3.transform.parent = BalsaD3.transform;
                        break;
                }
            }

            if (BalsaI == 0)
            {
                LugI = Random.Range(1, 4);

                BalsaI++;

                switch (LugI)
                {
                    case 1:
                        GameObject BalsaI1 = Instantiate(BalsaEnemigaI, new Vector3(-8, 1.4f, 0), Quaternion.identity);
                        GameObject Estela4 = Instantiate(Estela, new Vector3(BalsaI1.transform.position.x, BalsaI1.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela4.transform.parent = BalsaI1.transform;
                        break;

                    case 2:
                        GameObject BalsaI2 = Instantiate(BalsaEnemigaI, new Vector3(-8, -4.6f, 0), Quaternion.identity);
                        GameObject Estela5 = Instantiate(Estela, new Vector3(BalsaI2.transform.position.x, BalsaI2.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela5.transform.parent = BalsaI2.transform;
                        break;

                    case 3:
                        GameObject BalsaI3 = Instantiate(BalsaEnemigaI, new Vector3(-8, -10.6f, 0), Quaternion.identity);
                        GameObject Estela6 = Instantiate(Estela, new Vector3(BalsaI3.transform.position.x, BalsaI3.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela6.transform.parent = BalsaI3.transform;
                        break;
                }
            }

        }

        if (Puntaje.Nivel == 2)
        {

            if (BalsaA == 0)
            {
                LugA = Random.Range(1, 4);

                BalsaA++;

                switch (LugA)
                {
                    case 1:
                        GameObject BalsaA1 = Instantiate(BalsaEnemigaA, new Vector3(-12, 16, 0), Quaternion.identity);
                        GameObject Estela7 = Instantiate(Estela, new Vector3(BalsaA1.transform.position.x, BalsaA1.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela7.transform.parent = BalsaA1.transform;
                        break;

                    case 2:
                        GameObject BalsaA2 = Instantiate(BalsaEnemigaA, new Vector3(0, 20, 0), Quaternion.identity);
                        GameObject Estela8 = Instantiate(Estela, new Vector3(BalsaA2.transform.position.x, BalsaA2.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela8.transform.parent = BalsaA2.transform;
                        break;

                    case 3:
                        GameObject BalsaA3 = Instantiate(BalsaEnemigaA, new Vector3(12, 16, 0), Quaternion.identity);
                        GameObject Estela9 = Instantiate(Estela, new Vector3(BalsaA3.transform.position.x, BalsaA3.transform.position.y - 0.36f, 0), Quaternion.identity);
                        Estela9.transform.parent = BalsaA3.transform;
                        break;
                }
            }



        }

    }
}
