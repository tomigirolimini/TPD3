using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovGaviota : MonoBehaviour
{
   
    void Start()
    {
        transform.position = new Vector3(-30, Random.Range(-9, 5), 0);
    }


    void Update()
    {
        transform.Translate(new Vector3(1.5f, 0, 0) * Time.deltaTime);

        if(transform.position.x >= 15)
        {
           transform.position = new Vector3(-30, Random.Range(-9, 5), 0);
        }
    }
}
