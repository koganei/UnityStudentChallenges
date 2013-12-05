using UnityEngine;
using System.Collections;

public class dieOnCollision : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision collision) {
		Debug.Log("what");
		gameObject.SetActive(false);
	}
}
