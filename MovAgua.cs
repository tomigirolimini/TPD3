using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAgua : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(new Vector3(0, -0.2f, 0));

        if (transform.position.y <= -43.4f)
        {
            transform.position = new Vector3(0, 50.3f, 0);

        }
    }
}
