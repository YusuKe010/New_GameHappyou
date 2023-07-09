using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gem : itemBace
{
    int _gem = 100;

    public override void item()
    {
        FindObjectOfType<scoreManager>().AddGem(_gem);
    }
}
