using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Mathf.Repeat This is similar to the modulo operator but it works with floating point numbers.
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        // If time * scrollSpeed is equal to tileSizeZ (size of the tile)
        // newPosition is 0, so the sprite will be at its own startPosition
        transform.position = startPosition - Vector3.right * newPosition;
    }
}
