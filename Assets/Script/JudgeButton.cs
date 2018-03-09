using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeButton : MonoBehaviour {
	
	[SerializeField] private int position;
	public int Position { get { return position; } }
	[SerializeField] private string keyPosition;
	private AudioSource notes;

	private Material material;

	private Color 
		defaultColor = Color.red,
		pressedColor = Color.yellow;
	private float colorEasing = 2f;


	void Start () {
		material = GetComponent<Renderer>().material;
	}


	public void JudgeEffect(){
	}

	public void Update () {
		material.color = Color.Lerp (
			material.color,
			defaultColor,
			Time.deltaTime * colorEasing
		);
		if (Input.GetKeyDown(keyPosition)) {
			material.color = pressedColor;
		}
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
