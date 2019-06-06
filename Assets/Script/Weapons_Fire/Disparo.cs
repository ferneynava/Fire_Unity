using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public float Rango = 100;
    public GameObject Bala;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){

           RaycastHit hit;
           Vector3 Posicion = transform.parent.position;
           Vector3 Direccion = transform.TransformDirection(Vector3.forward);

            if(Physics.Raycast(Posicion,Direccion, out hit, Rango)){

            Quaternion Rotacion = Quaternion.FromToRotation(Vector3.up, hit.normal);

                Instantiate(Bala,hit.point,Rotacion);

            }
        }

       
    }

   
}
