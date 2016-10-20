using UnityEngine;
using System.Collections;
[System.Serializable]
public class wave {
	public GameObject generator; 
	public GameObject[] enemyArray;

	public void Activate () {
		foreach (GameObject enemy in enemyArray) {
			enemy.SetActive (true);
		}
	}
}

public class stats : MonoBehaviour {
    float prevGenEnabled;
	public int generatorsEnabled;
	public int sizeA;
	public int sizeB;
    public Sprite enabledImage;
	public wave[] waveArray;
    public GameObject[] Dots;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject dot in Dots)
        {
            if (generatorsEnabled > prevGenEnabled)
            {
                dot.GetComponent<SpriteRenderer>().sprite = enabledImage;
                prevGenEnabled = generatorsEnabled;

            }
        }

        prevGenEnabled = generatorsEnabled;

    }
}
