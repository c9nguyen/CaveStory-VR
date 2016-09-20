using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ParallaxLayer : MonoBehaviour {
	public float speedX;
	public float speedY;
	public bool moveInOppositeDirection;
    public GameObject gameCamera;


    private Transform cameraTransform;
	private Vector3 previousCameraPosition;
	private bool previousMoveParallax;
	private ParallaxOption options;

	void OnEnable() {
        gameCamera = GameObject.Find("OVRCameraRig");
		options = gameCamera.GetComponent<ParallaxOption>();
		cameraTransform = gameCamera.transform;
		previousCameraPosition = cameraTransform.position;
	}

	void Update () {
        Debug.Log(cameraTransform.transform);
		if(options.moveParallax && !previousMoveParallax)
			previousCameraPosition = cameraTransform.position;
        
        previousMoveParallax = options.moveParallax;

		if(!Application.isPlaying && !options.moveParallax)
			return;
       
        Vector3 distance = cameraTransform.position - previousCameraPosition;
        Debug.Log(distance);
        float direction = (moveInOppositeDirection) ? -1f : 1f;
		transform.position += Vector3.Scale(distance, new Vector3(speedX, speedY)) * direction;

		previousCameraPosition = cameraTransform.position;
	}
}
