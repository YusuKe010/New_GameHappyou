using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlakeBlock : MonoBehaviour
{
    [SerializeField] float count;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject, count);
        }
       
    }
}
