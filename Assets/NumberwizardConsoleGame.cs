using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumberwizardConsoleGame : MonoBehaviour {
	int max;
		int min;
		int guess;
		public int MaxGuesses=5;
		public Text text;

	// Use this for initialization
	void Start () {
		startgame ();
		
	}
	void startgame(){
		 max = 1000;
		 min = 1;
		nextGuess ();
	

	}
	void nextGuess()
	{
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString ();
		MaxGuesses=MaxGuesses-1;
		if(MaxGuesses<=0)
		{
			Application.LoadLevel("win");
		}
			
			 
	}
	// Update is called once per frame
	void Update () {
		

		
	}
	public void GuessHigher(){
		min = guess;
			nextGuess ();
	}
	public void GuessLower(){
		max = guess;
			nextGuess ();
	}

}
