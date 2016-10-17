using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	CharacterController controller;
	public float speed = 3;

	public float pushPower;
	void Start () {
	
		controller = GetComponent<CharacterController> ();
	}

	void Update () {
		//if(Input.GetKey(KeyCode.A))

		controller.Move(new Vector3(-speed*Time.deltaTime,0,0));

	}
    
	void OnControllerColliderHit(ControllerColliderHit hit){

		Rigidbody rig = hit.collider.attachedRigidbody;
		if (rig == null || rig.isKinematic)
			return;

		Vector3 vecPushDir = new Vector3 (hit.moveDirection.x,0,hit.moveDirection.z);
		rig.velocity = vecPushDir * pushPower;

	}



}


