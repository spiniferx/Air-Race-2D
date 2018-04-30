using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	// Use this for initialization
	public Text scoreText;
	public int score;
	bool gameover;

	void Start () {
		gameover = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	   
		scoreText.text = "Score: " + score;
	//	score = score + 1;

	}
	void scoreUpdate(){
		if (!gameover) {
			score = score + 1;
		}
	}
	public void gameOver(){
		gameover = true;
	}

	public void PlayButton(){
		//Application.LoadLevel ("level 1");
		SceneManager.LoadScene("level 1");
	}
		
	public void PauseButton(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;

		}
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}
}
