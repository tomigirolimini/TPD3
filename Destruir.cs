using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, 1.5f);
    }
}
