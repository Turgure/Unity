using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private bool isPause = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) {
			isPause = !isPause;
			Time.timeScale = isPause ? 0 : 1;
		}
	}
}
