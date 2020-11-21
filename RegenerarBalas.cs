using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenerarBalas : MonoBehaviour
{
    int tiempo = 0;
    float currentTime = 0;
    float maxTime = 1;

    public GameObject Disparo1;
    public GameObject Disparo2;
    public GameObject Disparo3;

    public static Renderer render;
    public static Renderer render1;
    public static Renderer render2;


    void Start()
    {
        render = Disparo1.GetComponent<Renderer>();
        render1 = Disparo2.GetComponent<Renderer>();
        render2 = Disparo3.GetComponent<Renderer>();

    }


    void Update()
    {
            currentTime += Time.deltaTime;

            if (currentTime >= maxTime)
            {

                currentTime = 0;

                tiempo++;

            }

            if (tiempo >= 2 && SwipeBarco.balasCreadas <= SwipeBarco.balasTotales)
            {
                tiempo = 0;

                switch (SwipeBarco.balasTotales)
                {

                    case 1:
                        SwipeBarco.balasCreadas = SwipeBarco.balasCreadas - 1;
                    SwipeBarco.render.enabled = true;
                        break;

                    case 2:
                        switch (SwipeBarco.balasCreadas)
                        {
                            case 2:
                                SwipeBarco.balasCreadas = SwipeBarco.balasCreadas - 1;
                            SwipeBarco.render1.enabled = true;
                                break;
                            case 1:
                                SwipeBarco.balasCreadas = SwipeBarco.balasCreadas - 1;
                            SwipeBarco.render.enabled = true;
                                break;
                        }
                        break;

                    case 3:
                        switch (SwipeBarco.balasCreadas)
                        {
                            case 3:
                                SwipeBarco.balasCreadas = SwipeBarco.balasCreadas - 1;
                            SwipeBarco.render2.enabled = true;
                                break;
                            case 2:
                                SwipeBarco.balasCreadas = SwipeBarco.balasCreadas - 1;
                            SwipeBarco.render1.enabled = true;
                                break;
                            case 1:
                                SwipeBarco.balasCreadas = SwipeBarco.balasCreadas - 1;
                            SwipeBarco.render.enabled = true;
                                break;

                        }
                        break;
                }


            }


        
    }
}
