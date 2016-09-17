using UnityEngine;
using System.Collections;

public class torchDecrease : MonoBehaviour {

    public float lifeTime;
    public Light lamp;
    private float lampMax;

	// Use this for initialization
	void Start () {
        lampMax = lamp.intensity;
	}
	
	// Update is called once per frame
	void Update () {
        lamp.intensity -= lampMax / lifeTime * Time.deltaTime;
    }

    public void dealDamage(float damage)
    {
        lamp.intensity -= damage;
    }
    
    public void killPlayer()
    {
        //
    }
}
