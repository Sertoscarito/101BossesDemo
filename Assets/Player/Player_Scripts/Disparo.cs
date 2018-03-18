using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	public GameObject bala;

	public GameObject DisparadorOBJ;
	Animator animator;


	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (ControlInputs.Botton_Golpear)) 
		{
			animator.SetInteger ("Accion", 1);
		}

		if (Input.GetKeyDown (ControlInputs.Botton_Up)) 
		{
			animator.SetInteger ("Accion",2);
		}

		if (Input.GetKeyUp (ControlInputs.Botton_Up)) 
		{
			animator.SetInteger ("Accion",3);
		}
	}

	public void Dispara()
	{
		
		Instantiate (bala, DisparadorOBJ.gameObject.transform.position, DisparadorOBJ.gameObject.transform.rotation);
		animator.SetInteger ("Accion", 0);
	}
}
