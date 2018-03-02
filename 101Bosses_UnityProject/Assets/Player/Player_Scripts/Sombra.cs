using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sombra : MonoBehaviour {


	void Start () {

		gameObject.GetComponent<SpriteRenderer>().receiveShadows = true;
		gameObject.GetComponent<SpriteRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.TwoSided;


	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
