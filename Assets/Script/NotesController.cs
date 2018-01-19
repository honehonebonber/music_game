using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NotesController : MonoBehaviour {
	
	private ParticleSystem particle;

	void Start () {
		Sequence seq = DOTween.Sequence();
		float posZ = JudgeManager.instance.GetJudgeBotton(0).transform.position.z;
		seq.Append(
			this.transform.DOMoveZ(posZ, 1.5f).SetEase(Ease.Linear)
		);
		seq.Append(
			this.transform.DOMoveZ(-175.0f, 0.5f).SetEase(Ease.Linear)//-17.6
		);
	}
	
	void Update () {
		
	}
}
