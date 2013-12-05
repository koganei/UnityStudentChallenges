using UnityEngine;
using System.Collections;

public class scoreOnHit : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision) {
		if(collision.collider.tag == "Bullet") {
			scoreCounter.score++;
		}
	}
}