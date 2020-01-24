using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetItem : MonoBehaviour
{
    // Start is called before the first frame update
  public UIManager manager;




  void OnTriggerEnter2D(Collider2D collider){
    
    Debug.Log(collider.gameObject.name);
    if(collider.gameObject.tag == "Item"){
      manager.setPoints(manager.getPoints()+ 5);
      
      Destroy(collider.gameObject);
    }
    


  }
}
