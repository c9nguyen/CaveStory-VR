using UnityEngine;
using System.Collections;

public class songCont : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(SongTimer());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator SongTimer()
    {
        yield return new WaitForSeconds(3.0f);
        GetComponent<AudioSource>().Play();
    }
}
