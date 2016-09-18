using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour {

    public int scene;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void respawnPlayer()
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
    }
}
