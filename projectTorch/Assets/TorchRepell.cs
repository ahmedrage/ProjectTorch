using UnityEngine;
using System.Collections;

public class TorchRepell : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "enemy") {
			other.transform.parent.GetComponent<AILerp>().speed = other.transform.transform.parent.GetComponent<enemyBeaviour>().initialSpeed/ GetComponent<Light> ().intensity;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "enemy") {
			other.transform.parent.GetComponent<AILerp>().speed = other.transform.transform.parent.GetComponent<enemyBeaviour>().initialSpeed;
		}
	}
}
