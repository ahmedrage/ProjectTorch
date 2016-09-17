using UnityEngine;
using System.Collections;

public class enemyBeaviour : MonoBehaviour {
	public Rigidbody2D rb;
	public float speed;
	public Transform player;
	public float rotationOffset;
	public enum state

	{
		idle,
		persuing
	}
	public state enemyState;
	public AILerp followScript;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		followScript = GetComponent<AILerp> ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (enemyState) {
		case state.persuing:
			Persue ();
			break;
		case state.idle:
			followScript.canMove = false;
			break;
		default:
			break;
		}
	}

	void Persue () {
		followScript.canMove = true;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			enemyState = state.persuing;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			enemyState = state.idle;
		}
	}
}
