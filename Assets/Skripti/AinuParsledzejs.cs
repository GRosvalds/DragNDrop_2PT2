using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	public void toStart(){
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}
	public void toGame (){
		SceneManager.LoadScene (1, LoadSceneMode.Single);
	}
	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

    
	public void Quit(){
		Application.Quit ();
	}
   
}
