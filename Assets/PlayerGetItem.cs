using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetItem : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D collider){
    
    UIManager UIManagerInstance = UIManager.instance;
    if(collider.gameObject.tag == "Item"){
      UIManagerInstance.setPoints(UIManagerInstance.getPoints()+5); 
      Destroy(collider.gameObject);
    }

  }
}
