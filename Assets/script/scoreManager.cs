using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    [SerializeField] Text _Scoretext;
    [SerializeField] Text _gemText;
    public int _Score;
    int _gemScore;
    // Start is called before the first frame update
    void Start()
    {
        AddScore(0);
        AddGem(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int _score)
    {
        _Score += _score;
        _Scoretext.text = _score.ToString();
    }
    public void AddGem(int _gem)
    {
        _gemScore += _gem;
        _gemText.text = _gemScore.ToString();
    }
}
