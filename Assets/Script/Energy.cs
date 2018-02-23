using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Energy : MonoBehaviour {
	private int energy;
	[SerializeField] private Text energyText;
	// Use this for initialization
	void Start () {
		//energy = GameManager.instance.user.musicResults [0].energy;
		energyText.text = (energy +"/300");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndEnergy(){
		SceneManager.LoadScene ("Select");
	}
}
