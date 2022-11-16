using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class SavePrefs : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas;
    public GameObject Loadbtn;
    public GameObject Clearbtn;

    public void Start()
    {
        Loadbtn.SetActive(false);
        Clearbtn.SetActive(false);
    }

    public void SavePlayer()
    {
        PlayerPrefs.SetString("CurScene", gameObject.scene.name);
        PlayerPrefs.SetFloat("XCord", player.transform.position.x);
        PlayerPrefs.SetFloat("YCord", player.transform.position.y);
        PlayerPrefs.SetInt("SaveFile", 1);
        PlayerPrefs.Save();
    }

    public void CheckIfSave()
    {
        if (PlayerPrefs.GetInt("SaveFile")==1)
        {
            Loadbtn.SetActive(true);
            Clearbtn.SetActive(true);
        }
    }

    void ChangePos()
    {
        float pX = PlayerPrefs.GetFloat("XCord");
        float pY = PlayerPrefs.GetFloat("YCord");
        Vector2 oldPos = new Vector2(pX, pY);
        player.transform.position = oldPos;
    }

    public void LoadPlayer()
    {
        if (PlayerPrefs.GetInt("SaveFile") == 1)
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("CurScene"));
            ChangePos();
            
        }
        else
        {
            Debug.LogError("NO SAVE FILE FOUND");
        }
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Data reset complete");
    }

}
