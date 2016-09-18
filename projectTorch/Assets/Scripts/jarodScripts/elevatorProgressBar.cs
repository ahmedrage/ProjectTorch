using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class elevatorProgressBar : MonoBehaviour {

    public string interactKey;
    public float waitTime;
    public Image image;
    public int sceneToLoad;
	public stats statScript;
	public GameObject prompt;

	// Use this for initialization
	void Start () {
		statScript = GameObject.Find ("GM").GetComponent<stats>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    
    //
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player" && statScript.generatorsEnabled >= 2)
        {
			if (Input.GetKey(KeyCode.E))
            {
                image.fillAmount += 1.0f / waitTime * Time.deltaTime;
                if (image.fillAmount >= 1.0f)
                {
                 SceneManager.LoadScene(sceneToLoad);
                }
            }
        }
    }

	void OnTriggerEnter2D (Collider2D coll) {
		if (image != null && coll.gameObject.tag == "Player") {
			prompt.SetActive (true);
			image.gameObject.SetActive (true);
		}
	}
	void OnTriggerExit2D (Collider2D coll) {
		if (image != null && coll.gameObject.tag == "Player") {
			prompt.SetActive (false);
			image.gameObject.SetActive (false);
		}
	}
}
