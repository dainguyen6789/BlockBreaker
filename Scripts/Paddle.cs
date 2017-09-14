using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos=new Vector3(7.71f,0.79f,-5f);
		float mousePosinBlocks = Input.mousePosition.x / Screen.width*15;
		//print (mousePosinBlocks);

		paddlePos.x = Mathf.Clamp (mousePosinBlocks, 0.64f, 15.34f);
		//print (paddlePos.x );
		//print (paddlePos.y );
		//print (paddlePos.z );
		this.transform.position = paddlePos;


	}
}
