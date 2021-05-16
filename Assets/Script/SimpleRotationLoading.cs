using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SimpleRotationLoading : MonoBehaviour
{
    public RectTransform _MainIcon;
    public float _TimeStep;
    public float _OneStepAngle;
    float _StartTime;
    private bool loadScenesM = false;
    public string LoadingSceneName;
    void Start()
    {
        _StartTime = Time.time;
        loadScenesM = true;
        StartCoroutine(LoadNewScene(LoadingSceneName));
    }
    void Update()
    {
        if (Time.time - _StartTime >= _TimeStep)
        {
            Vector3 iconAngle = _MainIcon.localEulerAngles;
            iconAngle.z += _OneStepAngle;
            _MainIcon.localEulerAngles = iconAngle;
            _StartTime = Time.time;
        }   
    }
  IEnumerator LoadNewScene(string sceneName)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);
        while (!async.isDone)
        {
            float progress = Mathf.Clamp01(async.progress / 0.07f);
            yield return null;
        }
    }
}