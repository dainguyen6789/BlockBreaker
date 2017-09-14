using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public int maxHits;
	public int timesHit;
	public Sprite[] hitSprite;
	public AudioClip crack;
	public Ball ball;
	//public MusicPlayer music_hitBrick;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		ball = GameObject.FindObjectOfType<Ball> ();;
		//paddle=GameObject.FindObjectOfType<Paddle>();
		//maxHits = 1;
	}
	
	// Update is called once per frame
	void Update () {


	
	}
	void OnCollisionEnter2D(Collision2D Col)
	{
		timesHit++;
			AudioSource.PlayClipAtPoint (crack,transform.position);

		if (timesHit == maxHits) {
			Destroy(gameObject);
			ball.DestroyedObject++;
		}
		else{
			LoadSprite();
		}
	}

	void LoadSprite(){

		this.GetComponent<SpriteRenderer> ().sprite = hitSprite [timesHit-1];

	}
	void run(){
		
	}
}
