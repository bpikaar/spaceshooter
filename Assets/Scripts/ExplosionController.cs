using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public float delay = 0f;

    // Use this for initialization
    void Start()
    {
        // GetCurrentAnimatorStateInfo(0).length returns the length of the animation
        // The object (explosion) will be removed after that time
        Destroy(
            gameObject, 
            this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay
        );
    }
}
