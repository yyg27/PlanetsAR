using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    public void SwitchScenes(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
