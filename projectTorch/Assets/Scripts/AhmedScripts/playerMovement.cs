using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public float speed;
	public Transform cursor;
	public float rotationOffset;
	public bool moving;
	public AudioSource walkSound;
	Animator anim;
	Rigidbody2D rb;
	float xInput;
	float yInput;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
		cursor = GameObject.FindGameObjectWithTag ("Cursor").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Move ();
		UpdateVars ();
	}

	void Update () {
		if ((Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0) && !walkSound.isPlaying)  {
			walkSound.UnPause ();
			print ("TESSST");
		} else {
			walkSound.Pause ();
		}
	}
	void UpdateVars () {
		xInput = Input.GetAxis ("Horizontal");
		yInput = Input.GetAxis ("Vertical");

		if (xInput != 0 || yInput != 0) {
			moving = true;
		} else {
			moving = false;
		}
		anim.SetBool ("moving", moving);
	}

	void Move () {
		rb.velocity = new Vector2 (xInput * speed, yInput * speed);	
		cursor.position = new Vector2 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		difference.Normalize ();
		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset); 
	}


}
