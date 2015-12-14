/**********************************************************************/
/*                                                                    */
/*                        NUMBER WIZARD UI							  */
/*		                                                              */
/*																	  */
/*		This is the code from a game created to practice my           */
/*      Unity and Game Development skills. All of this was            */
/*      made watching Ben Tristem's tutorial at Udemy.                */
/*                                                                    */
/*      For more information please visit:                            */
/*      https://www.udemy.com/unitycourse/                            */
/*                                                                    */
/*                                                                    */
/**********************************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	int maxGuessesAllowed = 10;
	public Text guessUI;
	
	// Use this for initialization
	void Start () {
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){ 
		max = guess;
		NextGuess();
	}
	
	void NextGuess() {
		//Random range goes from min inclusive to max exclusive, thus plus one
		guess = Random.Range(min,max+1);
		guessUI.text = "Is the number higher or lower than " + guess + " ?";
		maxGuessesAllowed--;
		if(maxGuessesAllowed<=0) {
			Application.LoadLevel("Won");
		}
	}
}
