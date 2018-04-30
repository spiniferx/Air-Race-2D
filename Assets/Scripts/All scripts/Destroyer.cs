using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	// Use this for initialization
	public uiManager ui;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		//Debug.Log ("destroy");
		if (col.gameObject.tag == "Enemy") {
			
			Destroy (gameObject);
			ui.gameOverActivated ();
		}
	}
}
