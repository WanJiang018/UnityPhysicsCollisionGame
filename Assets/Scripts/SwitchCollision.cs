using UnityEngine;
using System.Collections;

public class SwitchCollision : MonoBehaviour {

	public CharacterMove Charactor;
	bool switchenable = true;

	void OnCollisionEnter(Collision  collision){

		Debug.Log ("collided.");
		if(switchenable==true){
			Charactor.enabled=true;
			switchenable=false;
		}
	}
}
