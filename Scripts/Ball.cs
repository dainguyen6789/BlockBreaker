using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	public bool hasStarted=false;
	public int DestroyedObject;
	public Camera MainCamera;
	public string name;
	// Use this for initialization
	void Start () {
		paddle=GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		audio.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rawPos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, -20f);
		Vector2 worldPos = MainCamera.ScreenToWorldPoint (rawPos);
		print (worldPos);
		if (!hasStarted) {

			this.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButton (0)) {
				hasStarted=true;
				print ("Left Mouse Clicked");
				this.rigidbody2D.velocity = new Vector2 (-2f, 15f);
			}
		}
		if (DestroyedObject >= 5) {
			Application.LoadLevel(name);
			DestroyedObject=0;
		}
	}
	void OnCollisionEnter2D(Collision2D collider)
	{
		audio.Play ();
	}
}
