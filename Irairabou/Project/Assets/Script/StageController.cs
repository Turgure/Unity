using UnityEngine;
using System.Collections;

public class StageController : MonoBehaviour {
	public GameObject Light;

	private static bool isPause;

	// Use this for initialization
	void Start() {
		Vector3 Angle = new Vector3(0f, -30f, 0f);
		Light.transform.rotation = Quaternion.Euler(Angle);
		Pause();
	}

	// Update is called once per frame
	void Update() {
		updateStart();

		if(Input.GetKeyDown(KeyCode.Escape)) {
			if(isPause) {
				Resume();
			} else {
				Pause();
			}
		}
	}

	void updateStart() {
		if(Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if(Physics.Raycast(ray, out hit)) {
				GameObject obj = hit.collider.gameObject;

				if(obj.CompareTag("StartButton")) {
					gameStart();
				}
			}
		}
	}

	void gameStart() {
		Resume();
		Destroy(GameObject.FindGameObjectWithTag("StartButton"));

		Vector3 Angle = new Vector3(50f, -30f, 0f);
		Light.transform.rotation = Quaternion.Euler(Angle);
	}

	public static void Pause() {
		isPause = true;
		Time.timeScale = 0;
	}

	public static void Resume() {
		isPause = false;
		Time.timeScale = 1;
	}
}
