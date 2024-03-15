using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    public float changeLocation = 2.5f;

    private void OnTriggerEnter(Collider other);
    {
     private void OnTriggerEnter(Collider other);
    }

    void OnTriggerExit(Collider other);
    {
    int speedFactor = 9;
    object other = null;
    //Increasing the player's running speed
    other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
}
