using UnityEngine;
using System.Collections;

public class torchDecrease : MonoBehaviour {

    public float lifeTime;
    public Light lamp;
    private float lampMax;
    public GameObject respawnMenu;
	public Color InitialColor;
	public Color FlashColor;
	public float flashTime;
	public SpriteRenderer SR;
	// Use this for initialization
	void Start () {
        lampMax = lamp.intensity;
		SR = GameObject.Find ("Graphics").GetComponent<SpriteRenderer> ();
		InitialColor = SR.color;
	}
	
	// Update is called once per frame
	void Update () {
        lamp.intensity -= lampMax / lifeTime * Time.deltaTime;
    }

    public void dealDamage(float damage)
    {
        lamp.intensity -= damage;
		SR.color = FlashColor;
		StartCoroutine (flash ());
    }
    
    public void killPlayer()
    {
        respawnMenu.SetActive(true);
        Time.timeScale = 0;

    }

	IEnumerator flash () {
		yield return new WaitForSeconds (flashTime);
		SR.color = InitialColor;

	}
}
