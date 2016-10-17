using UnityEngine;
using System.Collections;

public class CollisionDomino : MonoBehaviour {

	public AudioClip collisionSource;
	public AudioClip IceSource;


	void OnCollisionEnter (Collision collision) {
	
		gameObject.GetComponent<AudioSource> ().PlayOneShot (collisionSource);


	}


	void OnCollisionStay (Collision collision){

		gameObject.GetComponent<AudioSource> ().PlayOneShot (IceSource);


	}

}
