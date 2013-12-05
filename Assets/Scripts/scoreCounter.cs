using UnityEngine;
using System.Collections;

public class scoreCounter : MonoBehaviour {

	public static int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if(score == 3) {
			Application.LoadLevel("GameOver");
		}
		if(score > 0) {
			this.guiText.text = "Score: " + score;
		}

	}
}
