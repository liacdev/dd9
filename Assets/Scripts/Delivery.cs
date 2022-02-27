using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

     void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package"){
            if(!hasPackage){
                hasPackage = true;    
                Destroy(other.gameObject, destroyDelay);
                Debug.Log("Got package! HasPackage: " + hasPackage);
            }else{
                Debug.Log("You already have a package. HasPackage: " + hasPackage);
            }

        }

        if (other.tag == "Customer"){
            if(hasPackage){
                hasPackage = false;
                Debug.Log("Package delivered! HasPackage: " + hasPackage);
            }else{
                Debug.Log("No package to deliver. HasPackage: " + hasPackage);
            }
        }
    }
}