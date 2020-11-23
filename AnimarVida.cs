using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimarVida : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

     
    void Update()
    {
        

       if (SwipeBarco.VidaF == 2.1f)
       {
            anim.SetFloat("Vida", 2.1f);

       }

        if (SwipeBarco.VidaF == 1.1f)
        {
            anim.SetFloat("Vida", 1.1f);

        }




    }
}
