
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviourJ {

	// Use this for initialization
	public override void Start() {

	}

	// Update is called once per frame
	public override void Update() {

	}

	public override void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.CompareTag("Player")) {
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(sceneIndex);
		}
	}
}
