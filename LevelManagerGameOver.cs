using UnityEngine;
using System.Collections;

public class LevelManagerGameOver : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Load level request" + name);
		Application.LoadLevel(name);
	}
	public void QuitRequest(){
		Debug.Log ("Dai Nguyen wnaa quit");
		Application.Quit ();
		
	}
}
