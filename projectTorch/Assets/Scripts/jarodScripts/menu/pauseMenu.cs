using UnityEngine;
using System.Collections;

public class pauseMenu : MonoBehaviour {

    public GameObject menu;

	// Use this for initialization
	void Start () {
        menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.Escape))
        {
            toggleActive(menu);
        }
	}

    public void toggleActive(GameObject obj)
    {
        if (!obj.activeSelf)
        {
            obj.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            obj.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
