using UnityEngine;
using System.Collections;

public class songmanager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(StartSong());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator StartSong()
    {
        yield return new WaitForSeconds(3.0f);
        GetComponent<AudioSource>().Play();
    }
}
