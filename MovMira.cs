using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMira : MonoBehaviour
{

    public GameObject Bala;

    public int velocidad = 6;
    float currentTime = 0;
    int Tiempo;
    int Segundo = 1;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Puntaje.Nivel != 0)
        {
            Destroy(gameObject);
        }

        if (transform.position != new Vector3(10, 35, 0) && transform.position.y > -3 )
        {

            transform.Translate(Vector3.down * Time.deltaTime * velocidad);

        }

        if(transform.position.y <= -3)
        {

            currentTime += Time.deltaTime;

            if(currentTime >= Segundo)
            {

                currentTime = 0;

                Tiempo++;

     


            }

            if (Tiempo == 4 && Puntaje.Puntos < 50)
            {
                Tiempo = 0;

                DestruirMira();
                Disparo();
            }

        }

    }

    void DestruirMira()
    {
        Destroy(gameObject);

    }
 
    void Disparo()
    {
        if (transform.position.x > -2 && transform.position.x < 2)
        {

            GameObject instanciaBala1 = Instantiate(Bala, new Vector3(0, -12, 5.0f), transform.rotation);
      
        }

        if (transform.position.x <= -3)
        {

            GameObject instanciaBala2 = Instantiate(Bala, new Vector3(0, -12, 5.1f), transform.rotation);
 
        }

        if (transform.position.x >= 3)
        {

            GameObject instanciaBala3 = Instantiate(Bala, new Vector3(0, -12, 5.2f), transform.rotation);
      
        }
    }

}

