using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NotesManager : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		this.transform.DOMoveZ(-26.399f, 1.5f);
		MoveToDestroy ();
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position += new Vector3 (0, 0, -10);
	}

	private void MoveToDestroy(){
		this.transform.DOMoveZ(-175.0f, 0.5f);//-17.6
	}
}
