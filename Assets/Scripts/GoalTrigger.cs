using UnityEngine;
using System.Collections;

public class GoalTrigger : MonoBehaviour {

	public GameObject Finish;
	public CharacterMove Character;

	void OnTriggerEnter (Collider other) {

		Debug.Log ("trigger");

		Finish.SetActive (true);

		if (other.name == "Capsule") {

		  Character.enabled=false;
		 }
	     
	     
		
	}
}
