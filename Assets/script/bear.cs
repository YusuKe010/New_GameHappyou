using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bear : MonoBehaviour
{
    [SerializeField] GameObject bearPrefab;
    bool bearEnabled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!bearEnabled && collision.CompareTag("Player"))
        {
            Instantiate(bearPrefab);
            bearEnabled = true;
        }
       
    }
}
