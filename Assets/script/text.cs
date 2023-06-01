using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    [SerializeField]　Text _text;
    string _start = ("スペースを押すと\nゲームスタート");
    // Start is called before the first frame update
    void Start()
    {
        _text.text = _start ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
