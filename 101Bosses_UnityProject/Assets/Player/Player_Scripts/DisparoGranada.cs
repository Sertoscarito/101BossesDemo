using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoGranada : MonoBehaviour {


	public GameObject GranadaOBJ;
	public GameObject Salida;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.K)) 
		{
			Instantiate (GranadaOBJ, Salida.gameObject.transform.position, Salida.gameObject.transform.rotation);			
		}
	}
}
