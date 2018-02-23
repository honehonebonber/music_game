using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager 
: SingletonMonoBehaviour<SoundManager> {

	[SerializeField] private AudioSource audioSource;
	public static SoundManager instance;
	void Start(){
		instance = this;
	}
	public void Play (AudioClip bgm) {
		audioSource.clip = bgm;
		audioSource.Play();	
	}

	public void Pause () {
		audioSource.Pause();
	}

}
