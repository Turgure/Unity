using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalController : MonoBehaviour {
	public GameObject Light;
	public UnityEngine.UI.Text ClearText;

	private bool isClear = false;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if(isClear) {
			if(Input.GetMouseButtonDown(0)) {
				SceneManager.LoadScene("Stage " + (int.Parse(SceneManager.GetActiveScene().name.Split(' ')[1]) + 1).ToString());
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")) {
			StageController.Pause();
			Vector3 Angle = new Vector3(0f, -30f, 0f);
			Light.transform.rotation = Quaternion.Euler(Angle);

			isClear = true;
			ClearText.gameObject.SetActive(true);
		}
	}
}
