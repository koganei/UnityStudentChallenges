using UnityEngine;
using System.Collections;

public class rotateHorizontal : MonoBehaviour {

	private Vector3 direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal") != 0) {
			transform.Rotate (Vector3.up * (Input.GetAxis("Horizontal") * 200) * Time.deltaTime);
		}

		// we're going to raycast to see if there are any hitboxes that are shootable
		direction = transform.right;

		RaycastHit hit = new RaycastHit();

		Debug.DrawRay(transform.position, direction * 10, Color.green);

		if(getHit(out hit)) {
			if(hit.collider.gameObject.tag == "Hitbox" && !hit.collider.gameObject.particleSystem.isPlaying) {
				// start the animation
				hit.collider.particleSystem.Play();
				StartCoroutine(stopHitboxAnimation(hit.collider));
			}
		}
	}

	private bool getHit(out RaycastHit hit) {
		return Physics.Raycast(transform.position, direction, out hit, 10.0f);
	}

	private IEnumerator stopHitboxAnimation (Collider collider) {
		RaycastHit hit;
		bool hittingSomething = getHit (out hit);

		while(hittingSomething && hit.collider == collider) {
			yield return new WaitForSeconds(0.5f);
			hittingSomething = getHit (out hit);
		}

		collider.particleSystem.Stop();

	}
}
