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

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}
	
	public void QuitGame(){
		Application.Quit();
	}
}
