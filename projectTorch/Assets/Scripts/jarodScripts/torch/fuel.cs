using UnityEngine;
using System.Collections;

public class batteries : MonoBehaviour {

    public float fuelValue;
    public Light lantern;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider coll) {
        if (coll.gameObject.tag == "Player")
        {
            //Run code to pick up battery here
            lantern.intensity += fuelValue;
        }
    }
}
