    using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public List<GameObject> myScene1;

    public List<GameObject> myFlintScene;


    void Awake()
    {
        myScene1 = new List<GameObject>();
        myFlintScene = new List<GameObject>();

    }

	// Use this for initialization
	void Start () {
        /*
        //diable all the scene1 game objects
        myScene1.AddRange(GameObject.FindGameObjectsWithTag("scene1"));
        foreach (GameObject obj in myScene1)
        {
            obj.SetActive(false);
        }

        myFlintScene.AddRange(GameObject.FindGameObjectsWithTag("flintScene"));
        foreach (GameObject obj in myFlintScene)
        {
            obj.SetActive(true);
        }
        */

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
