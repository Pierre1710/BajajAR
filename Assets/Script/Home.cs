using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public string LoadingSceneName;
    public void ButtonAtras()
    {
        SceneManager.LoadScene(LoadingSceneName);
    }
}
