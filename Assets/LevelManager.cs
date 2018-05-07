using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log (name);
		Application.LoadLevel (name);
	}
	public void QuitRequest(){
		Debug.Log ("i want to quit");
		Application.Quit ();
	}


}
