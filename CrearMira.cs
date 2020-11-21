using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrearMira : MonoBehaviour
{
   
    void Start()
    {
        
    }

    public GameObject Mira;

    int tiempo = 0;
    float currentTime = 0;
    float maxTime = 1;

    void Update()
    {
        
       if(Puntaje.Nivel == 0)
       { 

            currentTime += Time.deltaTime;

            if (currentTime >= maxTime)
            {

              currentTime = 0;

              tiempo++;

            }

            if (tiempo >= Random.Range(10, 20))
            {
                tiempo = 0;

                int lugar = Random.Range(0, 3);

                if (lugar == 0)
                {

                    GameObject instanciaMira1 = Instantiate(Mira, new Vector3(0, 14, 0), transform.rotation);

                }

                if (lugar == 1)
                {

                    GameObject instanciaMira2 = Instantiate(Mira, new Vector3(-4, 14, 0), transform.rotation);
                }

                if (lugar == 2)
                {

                    GameObject instanciaMira3 = Instantiate(Mira, new Vector3(4, 14, 0), transform.rotation);
                }



            }

       }

    }

}
