using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemBace : MonoBehaviour
{
   
    
    

    public virtual void item() {
        Debug.Log("item");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        { 
            item();
            Destroy(this.gameObject);
        }
    }
   
}
