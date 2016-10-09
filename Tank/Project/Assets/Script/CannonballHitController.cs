using UnityEngine;
using System.Collections;

public class CannonballHitController : MonoBehaviourJ {

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}

	public override void OnCollisionEnter(Collision collision) {
		if(!collision.gameObject.CompareTag("Tank")) {
			Destroy(gameObject);
		}
	}
}
