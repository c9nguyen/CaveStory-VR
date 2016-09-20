using UnityEngine;
using System.Collections;

public class EyeBlink : MonoBehaviour {

    public Animation eye;

    private float nextAnimationTime = 0f;
    private float period = 20f;

	// Use this for initialization
	void Start () {
        eye = GetComponent<Animation>();
        InvokeRepeating("blink", 0, 5);
    }

    void blink()
    {
        eye.Play();
    }

    // Update is called once per frame
    void Update() {

	}
}
