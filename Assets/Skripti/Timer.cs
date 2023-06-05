using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
	public Text TimerText;
	public Text TimerEnd;
	private float startTime;
	public Objekti objektuSkripts;
	public string mins;
	public string secs;
	public string H;
	 float t;

	void Start(){
		startTime = Time.time;
	}

	void Update () {
		if (objektuSkripts.score < 2) {
			 t = Time.time - startTime;
			if (((int) t/ 60) < 10) {
				 mins= ((int)t / 60).ToString ("00");
			} else {
				mins = ((int)t / 60).ToString ("0");
			}
			if ((t%60) < 10) {
				secs = (t % 60).ToString ("00");
			} else {
				secs = (t % 60).ToString ("0");
			}
			if (((int)t/60)< 10) {
				H = (((int)t/60)/60).ToString ("00");
			} else {
				H = (((int)t/60)/60).ToString ("0");
			}
			TimerText.text = H +":"+ mins + ":" + secs;

			
	}
		if (objektuSkripts.score == 2) {
			TimerEnd.text = H +":"+ mins + ":" + secs;

			if (((int)t / 60)<2) {
				objektuSkripts.zvaigzne1.SetActive (true);
				objektuSkripts.zvaigzne2.SetActive (true);
				objektuSkripts.zvaigzne3.SetActive (true);

			}
			if (((int)t / 60) > 2 && ((int)t / 60) < 3) {
				objektuSkripts.zvaigzne1.SetActive (true);
				objektuSkripts.zvaigzne2.SetActive (true);


			} else {
				objektuSkripts.zvaigzne1.SetActive (true);
			}
		}




}
}
