using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("enter");
            ChangeScene();
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("gameStart");
    }
}
