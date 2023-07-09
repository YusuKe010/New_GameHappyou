using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cherry :itemBace
{
    
    int _score = 1;

    public override void item()
    {
        FindObjectOfType<scoreManager>().AddScore(_score);
    }
}
