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

    private void toggleActive(GameObject obj)
    {
        if (!obj.activeSelf)
        {
            obj.SetActive(true);
        } else
        {
            obj.SetActive(false);
        }
    }
}
