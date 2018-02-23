using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NotesController : MonoBehaviour {
		
	private int _column, _row;
	public int Column { get{ return _column; } }
	public int Row { get{ return _row; } }

	public static readonly float ToMarkerDuration = 1.5f;

	const float 
		endZPos = -175.0f,
		toEndPosDuration = 0.5f;

	public void SetUp (int col, int row, Transform target) {
		_column = col;
		_row = row;
		var seq = DOTween.Sequence();
		var posZ = JudgeManager.instance.GetJudgeBotton(0).transform.position.z;
		seq.Append(
			this.transform.DOMoveZ(posZ, ToMarkerDuration).SetEase(Ease.Linear)
		);
		seq.Append(
			this.transform.DOMoveZ(endZPos, toEndPosDuration).SetEase(Ease.Linear)
		);
	}
	
}
