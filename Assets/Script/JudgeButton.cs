using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeButton : MonoBehaviour {
	
	[SerializeField] private int position;
	public int Position { get { return position; } }
	[SerializeField] private string keyPosition;
	private ParticleSystem particle;
	private AudioSource notes;

	// Use this for initialization
	void Start () {
		particle = this.GetComponent<ParticleSystem> ();
		particle.Stop();
		notes = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(keyPosition)) {
			JudgeManager.instance.Judge (this);
		}
	}

	public void JudgeEffect(){
		particle.Play ();
		notes.PlayOneShot (notes.clip);
	}
}
