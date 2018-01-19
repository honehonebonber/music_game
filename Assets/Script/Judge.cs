using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour {
	[SerializeField]
	private string keyPosition;
	private ParticleSystem particle;
	public static int score = 0;
	public static int combo = 0;
	public static int highScore;
	private AudioSource notes;
	private int indexTiming = 0;
	public static Judge instance;

	private bool isStart = false;

	public void JudgeStart(){
		isStart = true;
	}

	// Use this for initialization
	// void Start () {
	// 	instance = this;
	// 	particle = this.GetComponent<ParticleSystem> ();
	// 	particle.Stop();
	// 	highScore = PlayerPrefs.GetInt("HighScore");
	// 	notes = GetComponent<AudioSource>();
	// }
	
	// // Update is called once per frame
	// void Update () {
	// 	if (!isStart) return;
	// 	if (Touch ()) {
	// 		judge ();
	// 	}else if (TimeManager.instance.musicStart - MusicData.judgeTiming[indexTiming] >= 0.12f){
	// 		indexTiming++;
	// 	}
			
	// 	if (score > highScore) {
	// 		//ハイスコア更新
	// 		highScore = score;
	// 		//ハイスコアを保存
	// 		PlayerPrefs.SetInt("HighScore", highScore);
	// 		PlayerPrefs.Save();
	// 	}
	// }


	// /*void OnTriggerStay(Collider otherObj){
	// 	//if (Input.touchCount > 0) {
	// 	if (Input.GetKeyDown(keyPosition)) {
	// 		if (otherObj.gameObject.tag == "Notes") {
	// 			Destroy (otherObj.gameObject);
	// 			Debug.Log ("Nice");
	// 			particle.Play ();
	// 			notes.PlayOneShot (notes.clip);
	// 			combo++;
	// 			score += 100 + combo;
	// 		}
	// 	}
	// }*/

	// public bool Touch()
	// {
	// 	//if (input.touchCount > 0){
	// 	if (Input.GetKeyDown(keyPosition))
	// 		return true;
	// 	else
	// 		return false;
	// }

	// void judge(){
	// 	//if (input.touchCount > 0){
	// 	if (Input.GetKeyDown (keyPosition)) {
	// 		if(TimeManager.instance.musicStart - MusicData.judgeTiming[indexTiming] >= -0.3f &&TimeManager.instance.musicStart - MusicData.judgeTiming[indexTiming] <= 0.3f){
	// 			particle.Play ();
	// 			notes.PlayOneShot (notes.clip);
	// 			combo++;
	// 			indexTiming++;
	// 			score += 100 + combo;
			
	// 		}
	// 	}
	// }

}
