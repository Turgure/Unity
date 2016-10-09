using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject target;
	public float offsetX;
	public float offsetZ;
	public float lookDownAngle;
	public float yPos;

	private Vector3 pos;
	private Vector3 angle;
	private Vector3 targetPos;
	private Vector3 targetDirection;

	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		pos = transform.position;
		targetPos = target.transform.position;

		float angleDir = target.transform.eulerAngles.y * (Mathf.PI / 180.0f);
		targetDirection = new Vector3 (Mathf.Cos (angleDir), Mathf.Sin (angleDir), 0.0f);

		Debug.Log(targetDirection);

		pos.x = targetPos.x - offsetX * targetDirection.y;
		pos.z = targetPos.z - offsetZ * targetDirection.x;
		pos.y = yPos;

		angle.x = lookDownAngle;
		angle.y = target.transform.eulerAngles.y;

		// 最終的な位置角度
		transform.position = pos;
		transform.eulerAngles = angle;
	}
}
