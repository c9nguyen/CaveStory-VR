using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {


    public ParticleSystem ps;

	// Use this for initialization
	void Start () {
        ps.emissionRate = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPointerClick()
    {
        ps.Emit(30);
    }


}
