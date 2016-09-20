using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(IntroTimer());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator IntroTimer()
    {
        yield return new WaitForSeconds(9.0f);

        SceneManager.LoadScene("Dark");
        SceneManager.UnloadScene("Intro");
    }
}
