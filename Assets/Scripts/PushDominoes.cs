using UnityEngine;
using System.Collections;

public class PushDominoes : MonoBehaviour {
	public GameObject domioneStart;
	public float force=4.0f;

	void Update () {
	   if(Input.GetKeyDown(KeyCode.A)){
			domioneStart.GetComponent<Rigidbody>().AddForce(force,0,0,ForceMode.Impulse);

	}
}
}