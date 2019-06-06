using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalDestruir : MonoBehaviour
{


public float TiempoMaximo = 5.0f;


    // Update is called once per frame
    void Update()
    {


        if(Time.deltaTime <= TiempoMaximo){
        Destroy(gameObject);
        }

    }
}
