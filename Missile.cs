using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 7;

    // Fireball's movement
    void Start()
    {
        transform.position +=
        transform.forward *
        speed * Time.deltaTime;
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
