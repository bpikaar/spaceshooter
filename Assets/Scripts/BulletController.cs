using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float Speed;
    public GameObject explosion;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Time.deltaTime * Speed;

        transform.Translate(translation, 0, 0);
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit Enemy");
            // Spawn explosion. Explosion removes itself
            Instantiate(explosion, target.transform.position, target.transform.rotation);
            Destroy(target.gameObject);
            Destroy(gameObject);
        }
    }
}
