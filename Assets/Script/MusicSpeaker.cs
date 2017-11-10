using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSpeaker : MonoBehaviour {

	private AudioSource music;

	// Use this for initialization
	void Start () {
		music = GetComponent<AudioSource>();
		StartCoroutine ("musicSpeaker");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator musicSpeaker(){
		yield return new WaitForSeconds (1.0f);
		yield return new WaitForSeconds (TimeManager.instance.musicStart);
		music.PlayOneShot (music.clip);
	}

}
