﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mov_Player : MonoBehaviour
{
    public string InputHorizaontal,InputVertical;
    public float speed;
    private float Vertical;
    private float Horizontal;
    public float Gravity = 9.8f;
    private float VelocidadCaida; 
    public float JumpForce;

    public CharacterController player;
    public Camera Cam;
    private Vector3 MovPlayer;
    private Vector3 CamDelante;
    private Vector3 CamDerecha;
    private Vector3 Mov;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
           Horizontal = Input.GetAxis(InputHorizaontal);
           Vertical = Input.GetAxis(InputVertical);

           Mov = new Vector3 (Horizontal, 0.0f, Vertical);
           Mov = Vector3.ClampMagnitude(Mov, 1);

           Camdirection();

           MovPlayer = Mov.x * CamDerecha + Mov.z * CamDelante;

           MovPlayer = MovPlayer * speed;

           setGravity();
           saltarplayer();
           
           player.Move(MovPlayer * Time.deltaTime);


    }

    void Camdirection(){

     CamDelante = Cam.transform.forward; // Guardar la direccion hacia adelante de la camara principal 
     CamDerecha = Cam.transform.right;

     CamDelante.y = 0;
     CamDerecha.y = 0;

     CamDelante = CamDelante.normalized; // Valor normalizado de transform.forward
     CamDerecha = CamDerecha.normalized; // Valor normalizado de transform.right
    }

    void saltarplayer(){
        
        if(player.isGrounded && Input.GetButtonDown("Jump")){

            VelocidadCaida = JumpForce;
            MovPlayer.y = VelocidadCaida;

        }
    }

    void setGravity(){

        
        if(player.isGrounded){ //si el Jugador esta Tocando el suelo 
        VelocidadCaida = -Gravity * Time.deltaTime;
        MovPlayer.y = VelocidadCaida;
        } 
        else{
        VelocidadCaida -=  Gravity * Time.deltaTime;
        MovPlayer.y = VelocidadCaida;
        }
    }

    
}
