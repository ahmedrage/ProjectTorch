using UnityEngine;
using System.Collections;

public class enemyBeaviour : MonoBehaviour {
	public Rigidbody2D rb;
	public float speed;
	public Transform player;
	public float rotationOffset;
    public torchDecrease decreaseTorchClass;
	public AudioSource Attack;
	public enum state
	{
		idle,
		persuing
	}
	public state enemyState;
	public AILerp followScript;
	float initialRadius; 
	public float hitDelay;
	public float initialSpeed;
	float timeToHit;
	bool canHit;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		followScript = GetComponent<AILerp> ();
		followScript.target = player;
		initialSpeed = GetComponent<AILerp>().speed;
        decreaseTorchClass = GameObject.FindGameObjectWithTag("Lantern").GetComponent<torchDecrease>();
		initialRadius = GetComponent<CircleCollider2D> ().radius;
	}
	
	// Update is called once per frame
	void Update () {
		switch (enemyState) {
		case state.persuing:
			Persue ();
			break;
		case state.idle:
			followScript.canMove = false;
			canHit = false;
			break;
		default:
			break;
		}

		if (enemyState == state.persuing) {
			GetComponent<CircleCollider2D> ().radius = initialRadius * 5/4;
		} else {
			GetComponent<CircleCollider2D> ().radius = initialRadius;
		}
	}

	void Persue () {
		followScript.canMove = true;
		canHit = true;
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

	void OnCollisionStay2D (Collision2D coll) {
		if (coll.gameObject.tag == "Player" && Time.time > timeToHit && canHit == true) {
            decreaseTorchClass.dealDamage(2);
			timeToHit = Time.time + hitDelay;
			Attack.Play ();
		}
	}
}
