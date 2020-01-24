using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetItem : MonoBehaviour
{
    // Start is called before the first frame update
  public UIManager manager;




  void OnTriggerEnter2D(Collider2D collider){
    
    UIManager UIManagerInstance = UIManager.instance;
    if(collider.gameObject.tag == "Item"){
      UIManagerInstance.setPoints(UIManagerInstance.getPoints()+5); 
      Destroy(collider.gameObject);
    }

  }
}
