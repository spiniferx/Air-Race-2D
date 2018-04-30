using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelmeter : MonoBehaviour {

	// Use this for initialization
	public float speed =10f;
	Vector3 position;
	void Start () {
		position = transform.position;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		float t = Input.acceleration.x;
	//	float z = Input.acceleration.z;
		transform.Translate (t*speed*Time.deltaTime, 0, 0);
		position.x = Mathf.Clamp(position.x, -3.2f, 3.0f);
	//	transform.Rotate (0, 0, -z*speed*Time.deltaTime);
		// get the current position
		//apply this 
		/*
		position = transform.position;

		// apply an offset
		position.x += Input.acceleration.x * speed * Time.deltaTime;

		//clamp
		position.x = Mathf.Clamp(position.x, -3.2f, 3.2f);

		// apply
		transform.position = position;
		*/
	}
}
