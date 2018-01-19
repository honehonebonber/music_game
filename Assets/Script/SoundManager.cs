using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager 
: SingletonMonoBehaviour<SoundManager> {

	[SerializeField] private AudioSource audioSource;

	public void Play () {
		audioSource.Play();	
	}

	public void Pause () {
		audioSource.Pause();
	}

}
