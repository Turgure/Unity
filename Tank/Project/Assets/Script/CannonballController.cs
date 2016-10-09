using UnityEngine;
using System.Collections;

public class CannonballController : MonoBehaviourJ {
	public GameObject cannonballPrefab;
	public GameObject cannonballObject;
	public float speed;
	public AudioClip shotse;

	private GameObject cannonball;
	private Rigidbody rb;
	private Vector3 shotPos;
	private Quaternion shotAngle;

	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody>();
		shotPos = transform.position - cannonballPrefab.transform.position;
	}

	// Update is called once per frame
	void Update() {
		if(Input.GetKeyDown(KeyCode.Space)) {
			shot();
			AudioSource.PlayClipAtPoint(shotse, transform.position);
		}
	}

	void shot() {
		shotAngle = Quaternion.Euler(rb.rotation.eulerAngles.x + 90f, rb.rotation.eulerAngles.y, rb.rotation.eulerAngles.z);
		cannonball = (GameObject)Instantiate(cannonballPrefab, cannonballObject.transform.position, shotAngle);
		cannonball.transform.parent = cannonballObject.transform;
		cannonball.tag = "Cannonball";

		Rigidbody cannonballRB = cannonball.GetComponent<Rigidbody>();
		cannonballRB.AddForce(transform.forward * speed);
	}
}
