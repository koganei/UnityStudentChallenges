using UnityEngine;
using System.Collections;

public class scoreOnHit : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision) {
		if(collision.collider.tag == "Bullet") {
			// collision.collider.rigidbody.AddExplosionForce(200f, transform.position, 1000.0f);
			scoreCounter.score++;
		}
	}
}