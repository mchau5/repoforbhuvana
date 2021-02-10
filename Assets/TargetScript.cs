using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class TargetScript : MonoBehaviour
{
    public Score scoreManager;
    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision)
    {

        scoreManager.AddChip();
        // printing if collision is detected on the console
        Debug.Log("Collision Detected");
        //after collision is detected destroy the gameobject
        Destroy(gameObject);
    }

}