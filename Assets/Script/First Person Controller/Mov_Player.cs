using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mov_Player : MonoBehaviour
{
    public string InputHorizaontal,InputVertical;
    private float speed;
    private float Vertical;
    private float Horizontal;
    public float Gravity = 9.8f;
    private float VelocidadCaida; 
    public float JumpForce;
    public bool estaenRampla = false;
    public float slideVelocity;
    public float FuerzaabajoRam;
    public float walkSpeed, runSpeed;
    public float runBuildUpSpeed;


    public CharacterController player;
    public Camera Cam;
    private Vector3 MovPlayer;
    private Vector3 CamDelante;
    private Vector3 CamDerecha;
    private Vector3 Mov;
    private Vector3 hitNormal; // La Normal de el sitio en el que nuestro Jugador este Golpeando  
    [SerializeField] private KeyCode runKey;
    

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
           SetMovementSpeed();
           
           player.Move(MovPlayer * Time.deltaTime);


    }

    void SetMovementSpeed(){
       
       if (Input.GetKey(runKey))
       {
           speed = Mathf.Lerp(speed, runSpeed, Time.deltaTime * runBuildUpSpeed);
       }
       else{
           speed = Mathf.Lerp(speed, walkSpeed, Time.deltaTime * runBuildUpSpeed);
       }
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

        slidedown();
    }
    
    void slidedown (){ // comparar si nuestro Jugador esta o no esta en una Rampla y aplicar la fuerza necesaria para que se mueva 
          
          estaenRampla = Vector3.Angle(Vector3.up,hitNormal) >=  player.slopeLimit; // estaenRampla es verdadero siempre y cuando el angulo que hay entre el vector que apunta hacia arriba y la normal del plano en el que estamos sea mayor o igual al limite de la rampla de nuestro jugador 

        if (estaenRampla)
        {
            MovPlayer.x += ((1f - hitNormal.y) * hitNormal.x) * slideVelocity;
            MovPlayer.z += ((1f - hitNormal.z) * hitNormal.z) * slideVelocity;
            MovPlayer.y += FuerzaabajoRam;
        }
    }
    
    private void OnControllerColliderHit(ControllerColliderHit hit) { //Detectar cuando nuestro Character Controller Colisiona contra Otro objeto y se almazena en hit
        hitNormal = hit.normal; //La normal de lo que este chocando nuestro Jugador

    }

}
