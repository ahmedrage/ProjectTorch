using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	Vector3 target;
	public GameObject player;
	// Use this for initialization
	void Start () {
		//player = GameObject.FindGameObjectWithTag ("Player");

	}

	// Update is called once per frame
	void FixedUpdate () {
		target = (GameObject.FindGameObjectWithTag("Cursor").transform.position + player.transform.position) / 2;
		target = (target + player.transform.position) / 2;
		transform.position = Vector2.Lerp(transform.position, target, 0.1f);
		transform.position = new Vector3 (transform.position.x, transform.position.y, -10);
	
	}
}
