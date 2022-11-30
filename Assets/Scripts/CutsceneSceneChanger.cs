using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneSceneChanger : MonoBehaviour
{
    public float cutsceneTime;
    public string newScene;

    // Update is called once per frame
    void Update()
    {
        cutsceneTime -= Time.deltaTime;
        if (cutsceneTime <= 0)
        {
            SceneManager.LoadScene(newScene);
        }

        if(Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(newScene);
        }
    }
}
