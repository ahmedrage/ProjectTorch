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
	public int generatorsEnabled;
	public int sizeA;
	public int sizeB;
	public wave[] waveArray; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
