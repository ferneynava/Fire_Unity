using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Camara : MonoBehaviour
{
 public string Inputmousex,Inputmousey;
 public float sensibilidadx = 2f;
 public float sensibilidady = 2f;
 public Transform Player;
 private float mousex;
 private float mousey;
 private float xAxis;

    // Start is called before the first frame update
    public void Awake() {
        
        cursor();
        xAxis = 0.0f;
    }

    public void cursor(){
 
      Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mousex = Input.GetAxis(Inputmousex) * sensibilidadx;
        mousey = Input.GetAxis(Inputmousey) * sensibilidady;
        xAxis += mousey;

if (xAxis > 90.0f){
    xAxis = 90.0f;
    mousey = 0.0f;
    movimientoenXCam(270.0f);
}
else if (xAxis < -90.0f){
    xAxis = -90.0f;
    mousey = 0.0f;
     movimientoenXCam(90.0f);
}
        transform.Rotate(Vector3.left * mousey);
        Player.Rotate(Vector3.up * mousex);
         

    }

     private void movimientoenXCam(float valorx){
          
         Vector3 Rotacion = transform.eulerAngles;
          Rotacion.x = valorx;
          transform.eulerAngles = Rotacion;

}
}
