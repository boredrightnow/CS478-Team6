using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;
    // Start is called before the first frame update
    
    public void OnMouseUp()
    {
        if (isStart)
        {
            SceneManager.LoadScene("HedgeMaze");
        }
        if (isQuit)
        {
            Application.Quit();
        }
    }
}
