using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypop : MonoBehaviour
{
    [SerializeField] GameObject dog;
    [SerializeField] GameObject[] pop;
    bool _pop = false;
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
        if (_pop == false)
        {
            for (int i = 0; i < pop.Length; i++)
            {
                Instantiate(dog, pop[i].transform);
                
            }
            _pop = true;
        }
        
    }
}
