using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodeArmas : MonoBehaviour
{
    
    private bool Col1 = false;
    private bool Col2 = false;
    private bool Col3 = false;
    private bool Col4 = false;
    private bool Col5 = false;
    private bool Col6 = false;
    private bool Col7 = false;
    private bool Col8 = false;
    private bool Col9 = false;
    private bool Col10 = false;
    private bool Col11 = false;
    private bool Col13 = false;
    private bool Col14 = false;
    private bool Col16 = false;
    private bool Col17 = false;
    private bool Col18 = false;
    private bool Col19 = false;
    private bool Col20 = false;
    private bool Col21 = false;
    private bool Col22 = false;
    private bool Col23 = false;
    private bool Col24 = false;
    private bool Col25 = false;
    private bool Col26 = false;
    private bool Col27 = false;
    private bool Col28 = false;
    private bool Col29 = false;
    private bool Col30 = false;
   
    

    public GameObject[] Armas;
    public GameObject[] Weapons;
    private int Arma1 = 0;
    private int Arma2 = 1;
    private int Arma3 = 2;
    private int Arma4 = 3;
    private int Arma5 = 4;
    private int Arma6 = 5;
    private int Arma7 = 6;
    private int Arma8 = 7;
    private int Arma9 = 8;
    private int Arma10 = 9;
    private int Arma11 = 10;
    private int Arma12 = 11;
    private int Arma13 = 12;
    private int Arma14 = 13;
    private int Arma15 = 14;
    private int Arma16 = 15;
    private int Arma17 = 16;
    private int Arma18 = 17;
    private int Arma19 = 18;
    private int Arma20 = 19;
    private int Arma21 = 20;
    private int Arma22 = 21;
    private int Arma23 = 22;
    private int Arma24 = 23;
    private int Arma25 = 24;
    private int Arma26 = 25;
    private int Arma27 = 26;
    private int Arma28 = 27;
    private int Arma29 = 28;
    private int Arma30 = 29;
  
    
  

    void Start(){
         ArmasIniciales();
    }
    void Update() {

         Linterna ();

        if(Col1 ==  true && Input.GetButton("Recoger") ){
         Col1 = false;
         Armas[Arma1].SetActive(true);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
          
          Destroy(Weapons[Arma1]);  

          }

          if(Col2 ==  true && Input.GetButton("Recoger") ){
         Col2 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(true);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
        
          Destroy(Weapons[Arma2]);  

          }

           if(Col3 ==  true && Input.GetButton("Recoger") ){
         Col3 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(true);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma3]);  

          }
           if(Col4 ==  true && Input.GetButton("Recoger") ){
         Col4 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(true);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma4]);  

          }

           if(Col5 ==  true && Input.GetButton("Recoger") ){
         Col5 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(true);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
      
          Destroy(Weapons[Arma5]);  

          }
          if(Col6 ==  true && Input.GetButton("Recoger") ){
         Col6 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(true);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma6]);  

          }

           if(Col7 ==  true && Input.GetButton("Recoger") ){
         Col7 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(true);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
        
          Destroy(Weapons[Arma7]);  

          }
            if(Col8 ==  true && Input.GetButton("Recoger") ){
         Col8 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(true);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma8]);  

          }

          if(Col9==  true && Input.GetButton("Recoger") ){
         Col9 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(true);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma9]);  

          }

          if(Col10==  true && Input.GetButton("Recoger") ){
         Col10 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(true);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
        
          Destroy(Weapons[Arma10]);  

          }

           if(Col11==  true && Input.GetButton("Recoger") ){
         Col11 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(true);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma11]);  

          }

          if(Col13==  true && Input.GetButton("Recoger") ){
         Col13 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(true);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma12]);  

          }

           if(Col14 ==  true && Input.GetButton("Recoger") ){
         Col14 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(true);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma13]);  

          }

          if(Col16 ==  true && Input.GetButton("Recoger") ){
         Col16 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(true);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma14]);  

          }

            if(Col17 ==  true && Input.GetButton("Recoger") ){
         Col17 = false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(true);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma15]);  

          }

            if(Col18 ==  true && Input.GetButton("Recoger") ){
         Col18= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(true);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
          
          Destroy(Weapons[Arma16]);  

          }
          
          if(Col19 ==  true && Input.GetButton("Recoger") ){
         Col19= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(true);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
        
          Destroy(Weapons[Arma17]);  

          }

           if(Col20 ==  true && Input.GetButton("Recoger") ){
         Col20= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(true);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma18]);  

          }
          
           if(Col21 ==  true && Input.GetButton("Recoger") ){
         Col21= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(true);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma19]);  

          }

          if(Col22 ==  true && Input.GetButton("Recoger") ){
         Col22= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(true);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma20]);  

          }
        
         if(Col23 ==  true && Input.GetButton("Recoger") ){
         Col23= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(true);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
        
          Destroy(Weapons[Arma21]);  

          }
        
        if(Col24 ==  true && Input.GetButton("Recoger") ){
         Col24= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(true);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
          
          Destroy(Weapons[Arma22]);  

          }

          if(Col25 ==  true && Input.GetButton("Recoger") ){
         Col25= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(true);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
          
          Destroy(Weapons[Arma23]);  

          }

          if(Col26 ==  true && Input.GetButton("Recoger") ){
         Col26= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(true);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
        
          Destroy(Weapons[Arma24]);  

          }

           if(Col27 ==  true && Input.GetButton("Recoger") ){
         Col27= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(true);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         
          Destroy(Weapons[Arma25]);  

          }
          
          
           if(Col28 ==  true && Input.GetButton("Recoger") ){
         Col28= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(true);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
   
          Destroy(Weapons[Arma26]);  

          }

            if(Col29 ==  true && Input.GetButton("Recoger") ){
         Col29= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(true);
         Armas[Arma30].SetActive(false);
      
          Destroy(Weapons[Arma27]);  

          }

             if(Col30 ==  true && Input.GetButton("Recoger") ){
         Col30= false;
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(true);
  
          Destroy(Weapons[Arma28]);  

          }

          


           
          
        }
    
    void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "pistol"){
            Col1 = true;
             }

        if(other.gameObject.tag == "M64"){
            Col2 = true;
        }

        if(other.gameObject.tag == "AMrifle_1"){
            Col3 = true;
        }

        if(other.gameObject.tag == "bat"){
            Col4 = true;
        }

        if(other.gameObject.tag == "blaster"){
            Col5 = true;
        }

        if(other.gameObject.tag == "bow"){
            Col6 = true;
        }

        if(other.gameObject.tag == "carbine"){
            Col7 = true;
        }

        if(other.gameObject.tag == "chainsaw"){
            Col8 = true;
        }

        if(other.gameObject.tag == "CQ16"){
            Col9 = true;
        }

        if(other.gameObject.tag == "crossbow"){
            Col10 = true;
        }

        if(other.gameObject.tag == "flamer"){
            Col11 = true;
        }

        if(other.gameObject.tag == "HMG"){
            Col13 = true;
        }

         if(other.gameObject.tag == "knife"){
            Col14 = true;
        }

        if(other.gameObject.tag == "minigun"){
            Col16 = true;
        }

        if(other.gameObject.tag == "PDR"){
            Col17 = true;
        }

        if(other.gameObject.tag == "pistol2"){
            Col18 = true;
        }

        if(other.gameObject.tag == "pistol3"){
            Col19 = true;
        }

        if(other.gameObject.tag == "pulser"){
            Col20 = true;
        }

        if(other.gameObject.tag == "Qk"){
            Col21 = true;
        }

        if(other.gameObject.tag == "revolver"){
            Col22 = true;
        }

        if(other.gameObject.tag == "rpg8"){
            Col23 = true;
        }

        if(other.gameObject.tag == "SCrifle"){
            Col24 = true;
        }

        if(other.gameObject.tag == "shotgun"){
            Col25 = true;
        }

        if(other.gameObject.tag == "shotgun2"){
            Col26 = true;
        }

        if(other.gameObject.tag == "slugger"){
            Col27 = true;
        }

        if(other.gameObject.tag == "smg"){
            Col28 = true;
        }

        if(other.gameObject.tag == "smg3"){
            Col29 = true;
        }

        if(other.gameObject.tag == "sniper"){
            Col30 = true;
        }

       

        }

        void OnTriggerExit(Collider other) {
            if(other.gameObject.tag == "pistol"){
            Col1 = false;
             }

        if(other.gameObject.tag == "M64"){
            Col2 = false;
        }

        if(other.gameObject.tag == "AMrifle_1"){
            Col3 = false;
        }

        if(other.gameObject.tag == "bat"){
            Col4 = false;
        }

        if(other.gameObject.tag == "blaster"){
            Col5 = false;
        }

        if(other.gameObject.tag == "bow"){
            Col6 = false;
        }

        if(other.gameObject.tag == "carbine"){
            Col7 = false;
        }

        if(other.gameObject.tag == "chainsaw"){
            Col8 = false;
        }

        if(other.gameObject.tag == "CQ16"){
            Col9 = false;
        }

        if(other.gameObject.tag == "crossbow"){
            Col10 = false;
        }

        if(other.gameObject.tag == "flamer"){
            Col11 = false;
        }

        if(other.gameObject.tag == "HMG"){
            Col13 = false;
        }

         if(other.gameObject.tag == "knife"){
            Col14 = false;
        }

        if(other.gameObject.tag == "minigun"){
            Col16 = false;
        }

        if(other.gameObject.tag == "PDR"){
            Col17 = false;
        }

        if(other.gameObject.tag == "pistol2"){
            Col18 = false;
        }

        if(other.gameObject.tag == "pistol3"){
            Col19 = false;
        }

        if(other.gameObject.tag == "pulser"){
            Col20 = false;
        }

        if(other.gameObject.tag == "Qk"){
            Col21 = false;
        }

        if(other.gameObject.tag == "revolver"){
            Col22 = false;
        }

        if(other.gameObject.tag == "rpg8"){
            Col23 = false;
        }

        if(other.gameObject.tag == "SCrifle"){
            Col24 = false;
        }

        if(other.gameObject.tag == "shotgun"){
            Col25 = false;
        }

        if(other.gameObject.tag == "shotgun2"){
            Col26 = false;
        }

        if(other.gameObject.tag == "slugger"){
            Col27 = false;
        }

        
        if(other.gameObject.tag == "smg"){
            Col28 = false;
        }

         if(other.gameObject.tag == "smg3"){
            Col29 = false;
        }

         if(other.gameObject.tag == "sniper"){
            Col30 = false;
        }
        
    


        }

    void ArmasIniciales(){
         
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(false);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(true);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
         

    }
 
    
    void Linterna(){

        if(Input.GetButton("Linterna")){
         Armas[Arma1].SetActive(false);
         Armas[Arma2].SetActive(false);
         Armas[Arma3].SetActive(false);
         Armas[Arma4].SetActive(false);
         Armas[Arma5].SetActive(false);
         Armas[Arma6].SetActive(false);
         Armas[Arma7].SetActive(false);
         Armas[Arma8].SetActive(false);
         Armas[Arma9].SetActive(false);
         Armas[Arma10].SetActive(false);
         Armas[Arma11].SetActive(false);
         Armas[Arma12].SetActive(true);
         Armas[Arma13].SetActive(false);
         Armas[Arma14].SetActive(false);
         Armas[Arma15].SetActive(false);
         Armas[Arma16].SetActive(false);
         Armas[Arma17].SetActive(false);
         Armas[Arma18].SetActive(false);
         Armas[Arma19].SetActive(false);
         Armas[Arma20].SetActive(false);
         Armas[Arma21].SetActive(false);
         Armas[Arma22].SetActive(false);
         Armas[Arma23].SetActive(false);
         Armas[Arma24].SetActive(false);
         Armas[Arma25].SetActive(false);
         Armas[Arma26].SetActive(false);
         Armas[Arma27].SetActive(false);
         Armas[Arma28].SetActive(false);
         Armas[Arma29].SetActive(false);
         Armas[Arma30].SetActive(false);
        
        }
    }
            
        
        
    }

    

