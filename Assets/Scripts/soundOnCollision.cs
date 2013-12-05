using UnityEngine;
using System.Collections;

public class soundOnCollision : MonoBehaviour {

	public AudioClip soundToPlay;
	
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Ball") {
			AudioSource.PlayClipAtPoint(soundToPlay, transform.position);
		}
	}
}
