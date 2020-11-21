using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNube : MonoBehaviour
{
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.5f, -0.5f, 0) * Time.deltaTime);

        if (transform.position.x >= 15)
        {
            Destroy(gameObject);
        }
    }
}
