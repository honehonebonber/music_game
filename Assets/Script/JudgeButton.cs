using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeButton : MonoBehaviour {
	
	[SerializeField] private int position;
	public int Position { get { return position; } }
	[SerializeField] private string keyPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(keyPosition)) {
			JudgeManager.instance.Judge (this);
		}
	}
}
