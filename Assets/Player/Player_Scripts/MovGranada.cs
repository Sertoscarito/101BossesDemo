using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovGranada : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (500,500));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
