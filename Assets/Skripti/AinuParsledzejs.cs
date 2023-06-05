using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	//Pārslēdz uz sākuma ekrānu
	public void toStart(){
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}
	//Pārslēdz uz spēles ainu
	public void toGame (){
		SceneManager.LoadScene (1, LoadSceneMode.Single);
	}
	//Restartē esošo ainu
	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

    //Iziet no spēles
	public void Quit(){
		Application.Quit ();
	}
   
}
