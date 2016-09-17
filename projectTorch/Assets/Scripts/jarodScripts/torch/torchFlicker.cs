using UnityEngine;
using System.Collections;

public class torchFlicker : MonoBehaviour {

    public Light lantern;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lantern.intensity -= 0.5f / 1.0f * Time.deltaTime;
        lantern.intensity += 0.5f / 1.0f * Time.deltaTime;
    }
}
