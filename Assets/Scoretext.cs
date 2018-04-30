using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoretext : MonoBehaviour {

	// Use this for initialization

	public Text scoreText;
	public int score;
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
		score = score + 1;
	}
}
