using UnityEngine;
using System.Collections;

public class BallBounce : MonoBehaviour {

	public AudioClip BallSource;

	void OnCollisionEnter (Collision collision) {
		
		gameObject.GetComponent<AudioSource> ().PlayOneShot (BallSource);
		
		
	}
}
