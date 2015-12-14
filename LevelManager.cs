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
