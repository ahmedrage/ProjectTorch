using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class elevatorProgressBar : MonoBehaviour {

    public string interactKey;
    public float waitTime;
    public Image image;
    public int sceneToLoad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
    
    //
    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (Input.GetKey(interactKey))
            {
                image.fillAmount += 1.0f / waitTime * Time.deltaTime;
                if (image.fillAmount >= 1.0f)
                {
                 SceneManager.LoadScene(sceneToLoad);
                }
            }
        }
    }
}
