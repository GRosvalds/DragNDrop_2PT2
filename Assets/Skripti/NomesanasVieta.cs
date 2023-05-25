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
            vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
            velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;

            rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

            velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
            vietasIzm = GetComponent<RectTransform>().localPosition;

            xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
            yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

            if (eventData.pointerDrag.tag.Equals(tag))
			{
				
				if ((rotacijasStarpiba <= 10 || (rotacijasStarpiba >= 350 && rotacijasStarpiba <= 360))
                   && (xIzmeruStarp <= 0.3 && yIzmeruStarp <= 0.3))
                {
					objektuSkripts.vaiIstajaVieta = true;
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


                }
            }
		}
    }
}
