using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage = false;
  [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
  [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);
  [SerializeField] float destroyDelay = 1.0f;
  SpriteRenderer spriteRenderer;
   void Start() {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
   void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("AHH MY HEAD!");
  }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
          spriteRenderer.color = hasPackageColor;
          Debug.Log("Package Picked up!");
          hasPackage = true;
          Destroy(other.gameObject, destroyDelay);
        }
        if(other.tag == "Customer" && hasPackage){
          spriteRenderer.color = noPackageColor;
          Debug.Log("Hi Customer");
          hasPackage = false;
        }
    }
}
