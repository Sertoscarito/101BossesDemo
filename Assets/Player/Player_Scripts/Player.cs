using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Controller2D))]
public class Player : MonoBehaviour {

	public float jumpHeight = 4;
	public float timeToJumpApex = .4f;
	float accelerationTimeAirborne = .2f;
	float accelerationTimeGrounded = .1f;
	public float moveSpeed;
	private float valorINT;

	public float gravity;
	float jumpVelocity;
	Vector3 velocity;
	float velocityXSmoothing;
	public GameObject SpritesOBJ;
	Controller2D controller;

	public GameObject SupAnimationObj;
	public GameObject InfAnimationObj;
	Animator animations_INF;
	Animator animations_SUP;

	public GameObject Disparador;

	public bool Girado;
	public bool Agachado;
	public bool Saltando;
	public float Factor;
	public bool Ensuelo;

	void Start() {

		animations_SUP = SupAnimationObj.GetComponent<Animator> ();
		animations_INF = InfAnimationObj.GetComponent<Animator> ();

		controller = GetComponent<Controller2D> ();

		gravity = -(2 * jumpHeight) / Mathf.Pow (timeToJumpApex, 2);
		jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
		print ("Gravity: " + gravity + " Jump Velocity: " + jumpVelocity);
	}

	void Update() {
		
		//Debug.Log(Input.GetAxisRaw("Horizontal"));
		
		/*if (!Saltando) 
		{
			if (Input.GetKeyDown (ControlInputs.Botton_Down)) 
			{
				Agachado = true;
			}

			if (Input.GetKeyUp (ControlInputs.Botton_Down)) 
			{
				Agachado = false;
			}
			//Agachado = Input.GetKey (ControlInputs.Botton_Down);
		}*/

		if (controller.collisions.above || controller.collisions.below) {
				velocity.y = 0;
//				animations_INF.SetBool ("Salta", false);
			    Saltando = false;
			Ensuelo = true;
		}

		Vector2 input = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		if (Input.GetKeyDown (ControlInputs.Botton_Jump) && controller.collisions.below || Input.GetKeyDown (ControlInputs.MandoPlay_Cuadrado) && controller.collisions.below) 
		{
				velocity.y = jumpVelocity;
				animations_INF.SetInteger ("Accion", 2);
//				animations_INF.SetBool ("Salta", true);
			    Saltando = true;
			    Ensuelo = false;
		}


		if (input.x > 0) 
		{
			valorINT = 1;
		}

		if (input.x < 0) 
		{
			valorINT = -1;
		}

		if (input.x == 0) 
		{
			valorINT = 0;
		}

//		if(Input.GetKeyUp(ControlInputs.Botton_Right) || Input.GetKeyUp(ControlInputs.Botton_Left))
//		{
//			valorINT = 0;
//		}
		float targetVelocityX = valorINT * moveSpeed;
		velocity.x = Mathf.SmoothDampAngle (velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below)?accelerationTimeGrounded:accelerationTimeAirborne);		
		velocity.y += gravity * Time.deltaTime;
		controller.Move (velocity * Time.deltaTime * Factor);
		
		if (Input.GetAxisRaw ("Horizontal") > 0) 
		{
			SpritesOBJ.transform.localScale = new Vector3 (0.5F, 0.5F,0.5F);
			//Disparador.gameObject.transform.Rotate ( new Vector3(2.253f,90f,0f));

			if (!Saltando) {
				animations_INF.SetInteger ("Accion", 1);
			}

//			animations_INF.SetBool ("Corre", true);
//			animations_INF.SetBool ("Quieto", false);
			Girado = false;
			if (Agachado) {
				Factor = 0;
			} else 
			{
				Factor = 1;
			}
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) 
		{
			SpritesOBJ.transform.localScale = new Vector3 (-0.5F, 0.5F,0.5F);
			//Disparador.gameObject.transform.Rotate( new Vector3(2.253f,-90f,0f));
			if (!Saltando) 
			{
				animations_INF.SetInteger ("Accion", 1);
			}

//			animations_INF.SetBool ("Corre", true);
//			animations_INF.SetBool ("Quieto", false);
			Girado = true;
			if (Agachado) 
			{
				Factor = 0;
			}else 
			{
				Factor = 1;
			}
		}
		

		if (Input.GetAxisRaw ("Horizontal") == 0) 
		{
			if (!Saltando) 
			{
				animations_INF.SetInteger ("Accion", 0);
			}

//			animations_INF.SetBool ("Quieto", true);
//			animations_INF.SetBool ("Corre", false);
			if (Agachado) 
			{
				Factor = 0;
//				animations_INF.SetBool ("Agacha", true);
//				animations_SUP.SetBool ("Agacha", true);
			}else
			{
				Factor = 1;
				//animations_INF.SetBool ("Agacha", false);
		//		animations_SUP.SetBool ("Agacha", false);
			}

		}
     }
}