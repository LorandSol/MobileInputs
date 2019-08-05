using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputType : MonoBehaviour
{
    public GameObject zomling;
    public float upForce = 200f;

    void OnTouchDown()
    {
        zomling.GetComponent<Rigidbody>().velocity = (Vector3.up * upForce);
        Debug.Log("Down");
    }
    void OnTouchStay()
    {
        
        Debug.Log("Stay");
    }
    void OnTouchUp()
    {
        Debug.Log("Up");
    }
    void OnTouchExit()
    {
        Debug.Log("Exit");
    }
}
