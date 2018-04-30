using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Waitthenload : MonoBehaviour {

	public float waitTime;
	public string sceneToLoad;

	// Use this for initialization
	void Start () {
		StartCoroutine(WaitThenLoadFunction());
	}

	IEnumerator WaitThenLoadFunction() {
		yield return new WaitForSeconds(waitTime);
		SceneManager.LoadScene(sceneToLoad);
	}
}

