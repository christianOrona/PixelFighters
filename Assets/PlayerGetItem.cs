using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetItem : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D collider){
    
    UIManager UIManagerInstance = UIManager.instance;
    AudioManager audioManager = AudioManager.instance;
    
    if(collider.gameObject.tag == "Item"){
      
      Debug.Log("OnTriggerEnter :"+ (UIManagerInstance.getPoints()+5).ToString());
      UIManagerInstance.setPoints(UIManagerInstance.getPoints()+5);
      audioManager.PlaySound("Coin");
      Destroy(collider.gameObject);
    }

  }
}
