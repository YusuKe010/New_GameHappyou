using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
   public void SceneLode(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
