using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f;
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

     void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package"){
            if(!hasPackage){
                hasPackage = true;    
                spriteRenderer.color = hasPackageColor;
                Destroy(other.gameObject, destroyDelay);
                Debug.Log("Got package! HasPackage: " + hasPackage);
            }else{
                Debug.Log("You already have a package. HasPackage: " + hasPackage);
            }

        }

        if (other.tag == "Customer"){
            if(hasPackage){
                hasPackage = false;
                spriteRenderer.color = noPackageColor;
                Debug.Log("Package delivered! HasPackage: " + hasPackage);
            }else{
                Debug.Log("No package to deliver. HasPackage: " + hasPackage);
            }
        }
    }
}