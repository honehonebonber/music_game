using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision otherObj) {
		if (otherObj.gameObject.tag == "Notes") {
			Destroy(otherObj.gameObject);
			Debug.Log ("Bad");
			Judge.combo = 0;
		}
	}
}
