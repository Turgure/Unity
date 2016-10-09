using UnityEngine;
using System.Collections;

public class BlockHitController : MonoBehaviour {
	public AudioClip explosionSE;
	public GameObject explosionPrefab;

	private bool isHit = false;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if(isHit) {
			Vector3 pos = transform.position;
			Vector3 angle = transform.eulerAngles;

			pos.y += 0.05f;
			angle.x += 30f;
			transform.position = pos;
			transform.eulerAngles = angle;
		}
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.CompareTag("Cannonball")) {
			isHit = true;
			Destroy(gameObject, 1f);
			
			// 爆風
			AudioSource.PlayClipAtPoint(explosionSE, Camera.main.transform.position);
			GameObject explosion = (GameObject)Instantiate(explosionPrefab, transform.position, Quaternion.identity);
			Destroy(explosion.gameObject, 3f);
		}
	}
}
