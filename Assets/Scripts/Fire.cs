using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

    private Light light;
    private float intensity = 20;
    private float rate = 0.01f;
    private float flikFaktor;
   

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        light.range = intensity;
        // InvokeRepeating("Change", 0.5f, 0.5f);
        InvokeRepeating("Flicker", 0, 0.08f);
	}
	
	// Update is called once per frame
	void Update () {
        
        //intensity += rate;
        if (intensity <= 20)
        {
            rate = Random.Range(0.05f, 0.1f) ;
        } else if (intensity >= 39)
        {
            rate = Random.Range(-0.05f, -0.1f);
        }

        light.range = intensity + flikFaktor;
    }

    void Flicker()
    {
        flikFaktor = Random.Range(-0.9f, 0.9f);
    }


}
