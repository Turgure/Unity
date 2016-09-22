using UnityEngine;
using System.Collections;

public class CameraManip : MonoBehaviour {
	public GameObject viewObject;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = GetComponent<Transform>().position - viewObject.GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform>().position = viewObject.GetComponent<Transform>().position + offset;
	}
}
