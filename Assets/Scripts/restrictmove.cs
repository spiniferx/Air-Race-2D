using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restrictmove : MonoBehaviour {

	// Use this for initialization
	public float carspeed;
	public float minpos;
	public float maxpos;
	Vector3 position;
	void Start () {
		position = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis("Horizontal") * carspeed * Time.deltaTime;
		position.x=Mathf.Clamp (transform.position.x, -2.22f,2.47f );
		transform.position = position;
	}
}
