using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FlintController : MonoBehaviour {

    Animator myAnimator;
    Light mySparkLight;
    Animation myAnimation;
    AudioSource mySound;

    
	// Use this for initialization

     
	void Start () {
        SceneManager.UnloadScene("Fire");
        myAnimator = gameObject.GetComponentInChildren<Animator>();
        mySparkLight = gameObject.GetComponentInChildren<Light>();
        mySound = GetComponent<AudioSource>();
        //myAnimation = GetComponentInChildren<Animation>();




        StartCoroutine(CallSpark(2.0f));

        StartCoroutine(CallSpark(4.2f));

        StartCoroutine(CallSpark(4.6f));
        StartCoroutine(CallSpark(5.0f));
        StartCoroutine(CallSpark(6.3f));
        StartCoroutine(CallSpark(7.8f));

        StartCoroutine(AwakenCaveScene(7.0f));

    }

    IEnumerator AwakenCaveScene(float theWait)
    {
        yield return new WaitForSeconds(theWait);
        SceneManager.UnloadScene("Dark");
        SceneManager.LoadScene("Fire");
    }

    
	


    IEnumerator CallSpark(float theTime)
    {
        yield return new WaitForSeconds(theTime);
        myAnimator.SetTrigger("strikeTrig");
        mySound.Play();


    }


}
