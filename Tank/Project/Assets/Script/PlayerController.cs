using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float turnSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update() {
		move();
		rotation();
	}

	void move() {
		float translation = Input.GetAxis("Vertical");

		Vector3 movement = transform.forward * translation * speed * Time.deltaTime;
		rb.MovePosition(rb.position + movement);
	}

	void rotation() {
		float rotation = Input.GetAxis("Horizontal");

		float turn = rotation * turnSpeed * Time.deltaTime;
		Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
		rb.MoveRotation(rb.rotation * turnRotation);
	}
}
