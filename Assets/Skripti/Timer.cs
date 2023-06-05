using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
	//Pievienoti vajadzīgie objekti, un mainīgie
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
		//ja vēl visi objekti nav salikti pareizajās vietās, tad taimeris strādā, līdz ko viss ir salikts taimeris savu darbu beidz
		if (objektuSkripts.score < 12) {
			// t mainīgajam tiek piešķirts laiks
			 t = Time.time - startTime;
			// laiks tiek parveidots uz minutem
			// ja skaitlis ir viencipara, tad viņam pirms skaitļa būs nulle, bet ja ne tad nulle nav
			if (((int) t/ 60) < 10) {
				 mins= ((int)t / 60).ToString ("00");
			} else {
				mins = ((int)t / 60).ToString ("0");
			}
			// laiks tiek parveidots uz sekundem
			// ja skaitlis ir viencipara, tad viņam pirms skaitļa būs nulle, bet ja ne tad nulle nav
			if ((t%60) < 10) {
				secs = (t % 60).ToString ("00.0");
			} else {
				secs = (t % 60).ToString ("0.0");
			}
			// laiks tiek parveidots uz stundām
			// ja skaitlis ir viencipara, tad viņam pirms skaitļa būs nulle, bet ja ne tad nulle nav
			if (((int)t/60)< 10) {
				H = (((int)t/60)/60).ToString ("00");
			} else {
				H = (((int)t/60)/60).ToString ("0");
			}
			//Texta objektam tiek piešķirtas sekunžu, minūšu un stundu vērtības
			TimerText.text = H +":"+ mins + ":" + secs;

			
	}
		//Kad visas mašīnas ir novietotas izvada laiku, un cik zvaigznes atiecīgi laikam ir iegūtas
		if (objektuSkripts.score == 12) {
			TimerEnd.text = H +":"+ mins + ":" + secs;
			 //ja spēle pabeigta zem 2min, tad izvada 3 zvaigznes
			if (t<120) {
				objektuSkripts.zvaigzne1.SetActive (true);
				objektuSkripts.zvaigzne2.SetActive (true);
				objektuSkripts.zvaigzne3.SetActive (true);

			}
			//ja no 2 min līdz 3min, tad izvada 2 zvaigznes
			if (t>120 && t<180) {
				objektuSkripts.zvaigzne1.SetActive (true);
				objektuSkripts.zvaigzne2.SetActive (true);

				//ja vairāk par 3 min tad izvada 1 zvaigzni
			} else {
				objektuSkripts.zvaigzne1.SetActive (true);
			}
		}




}
}
