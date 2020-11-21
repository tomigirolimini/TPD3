using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPiedra : MonoBehaviour
{
    public GameObject Piedra;
    public int velocidad = 2;
    public static float Dificultad = 1.4f;

    

    void Start()
    {
        
    }


    void Update()
    {
      
        if (transform.position != new Vector3(13, 40, 0))
        {
            transform.Translate(new Vector3(0,-0.2f,0));

           
        }

        if (transform.position.y <= -17)
        {
            DestruirPiedra();
        }

    }

    void DestruirPiedra()
    {
    
       Puntaje.Objetos = Puntaje.Objetos - 1;
       Destroy(Piedra);
        
    }
    
}
