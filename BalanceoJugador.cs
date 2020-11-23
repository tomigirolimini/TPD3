using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceoJugador : MonoBehaviour
{
    public Transform target;
    public float Velocidad;

    public static Vector3 start, end;

    void Start()
    {
        if (target != null)
        {

            start = transform.position;
            end = target.position;

            start.x = start.x - 0.20f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
 
        if (target != null && Puntaje.Puntos < 20)
        {
            float fixedspeed = Velocidad * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedspeed);
        }

        if (transform.position == target.position && Puntaje.Puntos < 20 && Puntaje.Nivel != 2)
        {

            target.position = (target.position == start) ? end : start;
        }

       

    }

}
