using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeButton : MonoBehaviour {
	
	[SerializeField] private int position;
	public int Position { get { return position; } }
	[SerializeField] private string keyPosition;
	private AudioSource notes;


	void Start () {
		notes = GetComponent<AudioSource>();
	}


	public void JudgeEffect(){
		notes.PlayOneShot (notes.clip);
	}


	private void OnTriggerStay (Collider other) {
		if (Input.GetKeyDown(keyPosition)) {
			var notes = other.GetComponent<NotesController>();
			if (notes != null) {
				JudgeManager.instance.Judge(notes);
			}
		}
	}
}
