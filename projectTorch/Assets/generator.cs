using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Pathfinding;
public class generator : MonoBehaviour {
	public GameObject prompt;
	public bool triggered;
	public Image progressBar;
	public float ammountIncrease;
	bool canInteract;
	public stats statScript;
	public int index;
	public AudioSource startSound;
	// Use this for initialization
	void Start () {
		progressBar = transform.FindChild ("Canvas").FindChild ("progressBar").GetComponent<Image>();
		prompt = transform.FindChild ("keyprompt").gameObject;
		prompt.SetActive (false);
		progressBar.gameObject.SetActive (false);
		statScript = GameObject.FindGameObjectWithTag ("GM").GetComponent<stats>();
	}
	
	// Update is called once per frame
	void Update () {
		if (progressBar != null && progressBar.fillAmount >= 1) {
            transform.FindChild("Canvas").FindChild("Background").gameObject.SetActive(false);
			Destroy (progressBar.gameObject);
			prompt.SetActive (false);
			canInteract = false;
			statScript.generatorsEnabled++;
			transform.FindChild ("genLight").gameObject.SetActive (true);
			gameObject.layer = 5;
			AstarPath.active.Scan ();
			triggered = true;
			statScript.waveArray[index].Activate ();
			startSound.Play ();
		}
		if (progressBar != null && canInteract == true && Input.GetKey (KeyCode.E)) {
			progressBar.fillAmount += ammountIncrease * Time.deltaTime;
		}

	
	}

	void OnTriggerEnter2D (Collider2D coll) {
		if (progressBar != null && coll.gameObject.tag == "Player") {
			prompt.SetActive (true);
			canInteract = true;
			progressBar.gameObject.SetActive (true);
		}
	}
	void OnTriggerExit2D (Collider2D coll) {
		if (progressBar != null && coll.gameObject.tag == "Player") {
			prompt.SetActive (false);
			canInteract = false;
			progressBar.gameObject.SetActive (false);
		}
	}
}
