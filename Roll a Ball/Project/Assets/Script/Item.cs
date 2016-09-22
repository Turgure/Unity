using UnityEngine;
using System.Collections;

public class Item : MonoBehaviourJ {

	// Use this for initialization
	public override void Start() {

	}

	// Update is called once per frame
	public override void Update() {

	}

	public override void OnTriggerEnter(Collider hit) {
		if(hit.CompareTag("Player")) {
			Destroy(gameObject);
		}
	}
}
