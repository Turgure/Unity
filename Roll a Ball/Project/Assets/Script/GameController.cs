using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviourJ {
	public UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabel;

	// Use this for initialization
	public override void Start() {

	}

	// Update is called once per frame
	public override void Update() {
		int count = GameObject.FindGameObjectsWithTag("Item").Length;
		scoreLabel.text = count.ToString();

		if(count <= 0) {
			winnerLabel.SetActive(true);
		}
	}
}
