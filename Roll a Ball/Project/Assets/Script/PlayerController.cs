using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviourJ {
	public float speed = 10;

	// Use this for initialization
	public override void Start() {

	}

	// Update is called once per frame
	public override void Update() {

	}

	public override void FixedUpdate() {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		Vector3 vec = new Vector3(x * speed, 0, z * speed);

		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.AddForce(vec);
	}
}
