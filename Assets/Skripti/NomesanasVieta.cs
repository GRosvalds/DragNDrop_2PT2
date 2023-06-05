using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;



	
	public void OnDrop(PointerEventData eventData)
    {
        
		if (eventData.pointerDrag != null)
		{
            

            if (eventData.pointerDrag.tag.Equals(tag))
			{
                vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
                velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;

                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

                vietasIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                velkObjIzm = GetComponent<RectTransform>().localScale;

                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);
                

                if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
                   && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1))
                {
					objektuSkripts.vaiIstajaVieta = true;
					//kad objekts novietots pareizajā vietā, score mainigajam tiek piešķirta viena vērtība
					objektuSkripts.score += 1;
					//Score vertība tiek izvadīta teksta objektā
					objektuSkripts.points.text = objektuSkripts.score.ToString()+"/12";


					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
                   
                    switch (eventData.pointerDrag.tag)
                    {
                        case "Atkritumi":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
                            break;

                        case "Slimnica":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;

                        case "Skola":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
                        case "B2":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
                            break;
                        case "Cements":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[5]);
                            break;
                        case "E46":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
                            break;
                        case "E61":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
                            break;
                        case "Eskavators":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
                            break;
                        case "Policija":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
                            break;
                        case "Traktors1":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
                            break;
                        case "Traktors2":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[11]);
                            break;
                        case "Ugunsdzesejs":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[12]);
                            break;


                    }
                }

				
               

            } else
			{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag)
                {
                    case "Atkritumi":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        break;

                    case "Slimnica":
                        objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atraPKoord;
                        break;

                    case "Skola":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.busKoord;
                        break;
                    case "B2":
                        objektuSkripts.masinaB2.GetComponent<RectTransform>().localPosition = objektuSkripts.masB2Koord;
                        break;
                    case "Cements":
                        objektuSkripts.Cements.GetComponent<RectTransform>().localPosition = objektuSkripts.CementKoord;
                        break;
                    case "E46":
                        objektuSkripts.masinaE46.GetComponent<RectTransform>().localPosition = objektuSkripts.masE46Koord;

                        break;
                    case "E61":
                        objektuSkripts.masinaE61.GetComponent<RectTransform>().localPosition = objektuSkripts.masE61Koord;
                        break;
                    case "Eskavators":
                        objektuSkripts.eskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.eskavkoord;
                        break;
                    case "Policija":
                        objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.policKoord;
                        break;
                    case "Traktors1":
                        objektuSkripts.Traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.trak1Koord;
                        break;
                    case "Traktors2":
                        objektuSkripts.Traktors2.GetComponent<RectTransform>().localPosition = objektuSkripts.trak2Koord;
                        break;
                    case "Ugunsdzesejs":
                        objektuSkripts.ugunsdzesejs.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsKoord;
                        break;


                }
            }
		}
		//kad visas mašīnas ir vietā, tad tiek izvadīts beigu ekrāns
		//Tiek atskaņots uzvaras soundEfekts
		if(objektuSkripts.score ==12){
			objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[13]);
			objektuSkripts.izkartne.SetActive (true);

		}

        
    }
}
