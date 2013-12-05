using UnityEngine;
using System.Collections;

public class killOnCollision : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Killing something:" + collision.gameObject.name);
		if (collision.gameObject.name == "Wall") {
			collision.gameObject.SetActive(false);
		}
	}
}
