using UnityEngine;
using System.Collections;

public class torchDecrease : MonoBehaviour {

    public float lifeTime;
    public Light lamp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lamp.intensity -= 8.0f / lifeTime * Time.deltaTime;
    }
}
