using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class fadeScript : MonoBehaviour {
    public Color faceColor;
    public Image sr;
    public float currentVel;
    public float smoothTime = 2;
    public float timeToEnd = 8;
	// Use this for initialization
	void Start () {
        sr = GetComponent<Image>();
        timeToEnd += Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        sr.color = Color.Lerp(sr.color, faceColor, Time.deltaTime / smoothTime);
        if (Time.time >= timeToEnd)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
