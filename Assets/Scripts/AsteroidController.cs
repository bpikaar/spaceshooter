using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

    float horizontalMin;
    float horizontalMax;

    public float speed;

    // Use this for initialization
    void Start () {
        Camera camera       = Camera.main;
        float halfHeight    = camera.orthographicSize; // camera ziet een 2d vlak
        float halfWidth     = camera.aspect * halfHeight; // aspect is width devided bij height

        horizontalMin       = -halfWidth;
        horizontalMax       = halfWidth;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
	}

    /**
     * Is called when a object is no longer in the camera view
     * When a Object already is out-of-sight the method is not called
     */
    private void OnBecameInvisible()
    {
        transform.position = new Vector3(horizontalMax, transform.position.y, 0);
    }
}
