using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	// Use this for initialization
		public void LoadLevel(string name)
	{
		Debug.Log ("Game Scene" + name);
		Application.LoadLevel(name);
	}
}
