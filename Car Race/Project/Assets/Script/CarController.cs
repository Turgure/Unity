using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviourJ {
	public float speed = 10;
	public float turnSpeed = 3;

	private new Rigidbody rigidbody;

	// Use this for initialization
	public override void Start() {
		rigidbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	public override void Update() {
		float translation = Input.GetAxis("Vertical");
		float rotation = Input.GetAxis("Horizontal");

		float moveDistance = translation * speed;
		float turnAngle = rotation * turnSpeed;


		float angleDir = transform.eulerAngles.y * (Mathf.PI / 180.0f);
		Vector3 dir = new Vector3(Mathf.Cos(angleDir), Mathf.Sin(angleDir), 0.0f);
		rigidbody.AddForce(new Vector3(dir.x * moveDistance, 0.0f, -dir.y * moveDistance), ForceMode.VelocityChange);
		if(translation != 0) {
			if(translation < 0) {
				turnAngle *= -1;
			}
			rigidbody.AddTorque(Vector3.up * turnAngle, ForceMode.VelocityChange);
		}

		// 初期化
		if(Input.GetKey(KeyCode.Space)) {
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(sceneIndex);
		}
	}

	public override void LateUpdate() {
		rigidbody.angularVelocity = rigidbody.angularVelocity / 1.2f;
	}
}
