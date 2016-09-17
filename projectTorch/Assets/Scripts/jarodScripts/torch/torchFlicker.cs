using UnityEngine;
using System.Collections;

public class torchFlicker : MonoBehaviour {

    public Light lantern;
    public torchDecrease decreaseClass;

    // Use this for initialization
	void Start () {
        StartCoroutine(flickerLight());
        decreaseClass = GameObject.Find("Point light").GetComponent<torchDecrease>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    IEnumerator flickerLight()
    {
        if (lantern.intensity > 0.0f)
        {
            lantern.intensity += Random.Range(0.0f, 0.2f);
            yield return new WaitForSeconds(0.2f);
            lantern.intensity -= Random.Range(0.0f, 0.2f);
            yield return new WaitForSeconds(0.2f);
            StartCoroutine(flickerLight());
        } else
        {
            lantern.intensity += Random.Range(0.0f, 0.2f);
            yield return new WaitForSeconds(0.2f);
            lantern.intensity += Random.Range(0.0f, 0.2f);
            yield return new WaitForSeconds(0.2f);
            lantern.intensity = 0.0f;
            decreaseClass.killPlayer();
        }
    }
}
