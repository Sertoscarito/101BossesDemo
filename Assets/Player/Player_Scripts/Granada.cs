using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour {

	public GameObject GranadaOBJ;
	private GameObject Granade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.O)) 
		{
			InstantiateGranada ();
		}
		
		
	}

	public void OnMouseDown()
	{
		InstantiateGranada ();
	}

	public void InstantiateGranada()
	{
		Debug.Log ("Entro");
		GameObject gr;
		Vector2 fza = new Vector2 (5, 15);
		gr = Instantiate (GranadaOBJ, transform.position, transform.rotation);
		gr.GetComponent<Rigidbody2D> ().AddRelativeForce (fza, ForceMode2D.Impulse);
//		Granade = Instantiate(GranadaOBJ, transform.position, transform.rotation); 
//		Rigidbody2D rb = Granade.gameObject.GetComponent<Rigidbody2D> ();
//		rb.AddRelativeForce (Vector2 (0,15), ForceMode2D.Impulse);
//		Granade.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(Vector3(0,0,15),ForceMode.Impulse);
	}
}
