using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class EnemyCreator : MonoBehaviour {

    float horizontalMax;
    float verticalMax;

    public GameObject enemy;

    // Use this for initialization
    void Start () {
        Camera camera       = Camera.main;
        float halfHeight    = camera.orthographicSize; // camera ziet een 2d vlak

        horizontalMax       = camera.aspect * halfHeight;
        verticalMax         = halfHeight;

        // Calls the CreateEnemy method after 0.5 seconds. 
        // This is repeated after 1 second.
        InvokeRepeating("CreateEnemy", 0.5f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateEnemy() {
        float verticalPosition = Random.Range(-verticalMax, verticalMax);

        GameObject enemyClone = Instantiate(
            enemy,
            new Vector3(horizontalMax, verticalPosition, 0),
            transform.rotation) as GameObject;
    }
}
