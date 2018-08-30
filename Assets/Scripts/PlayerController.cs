using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 touchOrigin = -Vector2.one; //Used to store location of screen touch origin for mobile controls.

    public float speed;
    public float rotationSpeed;

    public GameObject rocket;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Nu gebruik gemaakt van twee manieren om 
        // bijvoorbeeld ook te kunnen laten zien hoe je een forward movement doet
        // tov het object zelf. Bij Translate zet je de laatste optie dan op
        // Space.self (of weglaten)


        // Movement relative to world axis
        float horizontal    = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical      = Input.GetAxis("Vertical")   * speed * Time.deltaTime;

        transform.Translate(0,          vertical,   0, Space.World);
        transform.Translate(horizontal, 0       ,   0, Space.World);


        // Movement realative to self (object normal vector)
        //float translation   = Input.GetAxis("Vertical") * speed;
        //float rotation      = Input.GetAxis("Horizontal") * rotationSpeed;

        //translation         *= Time.deltaTime;
        //rotation            *= Time.deltaTime;

        //transform.Translate(translation, 0, 0);
        //transform.Rotate(0, 0, rotation);

        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
            Debug.Log("Shoot");
        }
    }

    private void Fire()
    {
        GameObject rocketClone = Instantiate(
            rocket,
            transform.position,
            transform.rotation) as GameObject;
    }
}
