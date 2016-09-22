using UnityEngine;
using System.Collections;

public class UnityChanController2 : MonoBehaviourJ {
	private Animator animator;
	private int doWalkID;

	// Use this for initialization
	void Start() {
		animator = GetComponent<Animator>();
		doWalkID = Animator.StringToHash("DoWalk");
	}

	// Update is called once per frame
	void Update() {
		if(Input.GetKey(KeyCode.UpArrow)) {
			animator.SetBool(doWalkID, true);
		} else {
			animator.SetBool(doWalkID, false);
		}
	}
}
