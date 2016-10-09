using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 5f;

	private Rigidbody rb;
	private Vector3 velocity;
	private float dir;
	private Vector3 mousePos;

	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update() {
		updateMousePos();
		//Debug.Log(mousePos);
	}

	void FixedUpdate() {
		dir = Mathf.Atan2(mousePos.z - transform.position.z, mousePos.x - transform.position.x);
		velocity = new Vector3(Mathf.Cos(dir), 0f, Mathf.Sign(dir)) * speed;
		rb.AddForce(velocity);
	}

	void updateMousePos() {
		mousePos = Input.mousePosition;
		mousePos.z = 10f;
		mousePos = Camera.main.ScreenToWorldPoint(mousePos);
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("Wall")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
