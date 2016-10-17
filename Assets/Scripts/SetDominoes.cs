using UnityEngine;
using System.Collections;

public class SetDominoes : MonoBehaviour {
	public GameObject dominoPrefab;
	public GameObject dominoEnd;
	public int Number=10;

	void Start () {
	
		Vector3 dir = dominoEnd.transform.position - transform.position;
		float interval = dir.magnitude / (Number + 1);
		dir.Normalize ();

		for (int i =1; i<=Number; i++) {
			GameObject newDom = (GameObject)Instantiate(dominoPrefab);
			newDom.transform.position=transform.position+dir*interval*i;
			newDom.transform.rotation=transform.rotation;
		
		}
	
	
	}

	void Update () {
	
	}
}
