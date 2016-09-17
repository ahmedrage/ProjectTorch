using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    public int sceneToLoad;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void openMainMenu()
    {
        SceneManager.LoadScene(sceneToLoad);
        Time.timeScale = 1;
    }
}
