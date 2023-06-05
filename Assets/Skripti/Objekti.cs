using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objekti : MonoBehaviour {

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject masinaB2;
	public GameObject Cements;
	public GameObject masinaE46;
	public GameObject masinaE61;
	public GameObject eskavators;
	public GameObject policija;
	public GameObject Traktors1;
	public GameObject Traktors2;
	public GameObject ugunsdzesejs;
	public GameObject izkartne;
	public GameObject zvaigzne1;
	public GameObject zvaigzne2;
	public GameObject zvaigzne3;
	public float score = 0;
	public Text points;


	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 busKoord;
    [HideInInspector]
    public Vector2 masB2Koord;
    [HideInInspector]
    public Vector2 CementKoord;
    [HideInInspector]
    public Vector2 masE46Koord;
    [HideInInspector]
    public Vector2 masE61Koord;
    [HideInInspector]
    public Vector2 eskavkoord;
    [HideInInspector]
    public Vector2 policKoord;
    [HideInInspector]
    public Vector2 trak1Koord;
    [HideInInspector]
    public Vector2 trak2Koord;
    [HideInInspector]
    public Vector2 ugunsKoord;

    public Canvas kanva;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;
    

    // Use this for initialization
    void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atraPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        busKoord = autobuss.GetComponent<RectTransform>().localPosition;
        masB2Koord = masinaB2.GetComponent<RectTransform>().localPosition;
        CementKoord = Cements.GetComponent<RectTransform>().localPosition;
        masE46Koord = masinaE46.GetComponent<RectTransform>().localPosition;    
        masE61Koord = masinaE61.GetComponent<RectTransform>().localPosition;
        eskavkoord = eskavators.GetComponent<RectTransform>().localPosition;
        policKoord = policija.GetComponent<RectTransform>().localPosition;
        trak1Koord = Traktors1.GetComponent<RectTransform>().localPosition;
        trak2Koord = Traktors2.GetComponent<RectTransform>().localPosition;
        ugunsKoord = ugunsdzesejs.GetComponent<RectTransform>().localPosition;
    }

	
}
