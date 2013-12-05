using UnityEngine;
using System.Collections;

public class shootBullets : MonoBehaviour {

	public GameObject bulletModel;
	public float bulletSpeed = 5.0f;

	private GameObject bullet;
	private Vector3 bulletDirection;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && bullet == null) {
			bullet = (GameObject) Instantiate(bulletModel, transform.position, bulletModel.transform.rotation);

			bullet.transform.parent = null;

			bulletDirection = transform.right;
		}

		if (bullet != null)  {
			bullet.transform.position += bulletDirection * Time.deltaTime * bulletSpeed;
		}

		if (bullet != null && bullet.transform.position.z - transform.position.z > 10) {
			Object.Destroy(bullet);
			bullet = null;
		}

	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("test");
		scoreCounter.score += 1;
	}
}