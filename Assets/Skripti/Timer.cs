using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour {
	public GUIText TimerText;
	public float time;
	

	void Update () {
		time = time += Time.deltaTime;
		TimerText.text = time.ToString ();
	}
}
