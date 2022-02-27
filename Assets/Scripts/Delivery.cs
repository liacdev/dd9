using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

     void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package"){
            if(!hasPackage){
                hasPackage = true;    
                Debug.Log("Got package! HasPackage: " + hasPackage);
            }else{
                Debug.Log("You already have the package. HasPackage: " + hasPackage);
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