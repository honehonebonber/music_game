using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeManager : MonoBehaviour {
	public static JudgeManager instance;
	public float musicStart = 4.0f;
	private float timer;
	public float Timer{ get {return timer; } }
	void Start(){
		instance = this;
	}
	public void Judge(JudgeButton judgeButton){
		
	}
}
