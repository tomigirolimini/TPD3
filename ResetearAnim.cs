using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetearAnim : MonoBehaviour
{
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>(); 
    }


    void Update()
    {
        
        if(Puntaje.Puntos == 99)
        {
            animator.SetBool("Desaparecer", true);
        }

        if(Puntaje.Puntos == 104)
        {
            animator.SetBool("Desaparecer", false);
        }
    }
}
