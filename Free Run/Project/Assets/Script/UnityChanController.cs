using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviourJ {
	private Animator animator;
	private Locomotion locomotion = null;
	private AnimatorStateInfo animatorStateInfo;
	private CharacterController characterController;
	private float speed = 0;
	private float direction = 0;
	private float jumpSpeed = 0;
	private Vector3 moveDirection;

	// Use this for initialization
	public override void Start() {
		animator = GetComponent<Animator>();
		locomotion = new Locomotion(animator);
		characterController = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	public override void Update() {
		if(animator && Camera.main) {
			JoystickToEvents.Do(transform, Camera.main.transform, ref speed, ref direction);

			if(Input.GetKey(KeyCode.LeftShift)) {
				speed *= 3;
			}

			locomotion.Do(speed * 6, direction * 180);
		}

		animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

		if(Input.GetKeyDown(KeyCode.Space)) {
			animator.SetBool("Jump", true);
		}


		if(animatorStateInfo.IsName("Locomotion.JUMP00")) {
			if(animator.GetBool("Jump")) {
				float horizontal = Input.GetAxis("Horizontal");
				float vertical = Input.GetAxis("Vertical");
				Vector2 speedVec = new Vector2(horizontal, vertical);
				jumpSpeed = Mathf.Clamp(speedVec.magnitude, 0, 1);

				Vector3 rootDirection = transform.forward;
				Vector3 stickDirection = new Vector3(horizontal, 0, vertical);
				Vector3 CameraDirection = Camera.main.transform.forward;
				CameraDirection.y = 0.0f; // kill Y
				Quaternion referentialShift = Quaternion.FromToRotation(Vector3.forward, CameraDirection);
				moveDirection = referentialShift * stickDirection;
			}

			animator.SetBool("Jump", false);


			characterController.Move(moveDirection * jumpSpeed * 3 * Time.deltaTime);
		}
	}
}
