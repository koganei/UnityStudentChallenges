using UnityEngine;
using System.Collections;

public class ApplyForceOnKey : MonoBehaviour {

	public KeyCode key;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(key)) {
			rigidbody.AddRelativeForce(0f, 0f, 5000f);
		}
	}
}
