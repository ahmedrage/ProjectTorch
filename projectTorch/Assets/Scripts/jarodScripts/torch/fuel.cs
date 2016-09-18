using UnityEngine;
using System.Collections;

public class fuel : MonoBehaviour {

    public float fuelValue;
    public Light lantern;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Player")
        {
            //Run code to pick up battery here
            lantern.intensity += fuelValue;
			Destroy (gameObject);
        }
    }
}
