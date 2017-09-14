using UnityEngine;
using System.Collections;

public class LoseColllider : MonoBehaviour {

	public LevelManagerGameOver levelManager;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D trigger){
		print ("Trigger");
		//levelManager.LoadLevel("Win");
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		print ("Collision");
	}

}
