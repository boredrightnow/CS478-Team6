using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class SavePrefs : MonoBehaviour
{
    public GameObject player;

    public void SavePlayer()
    {
        PlayerPrefs.SetString("CurScene", gameObject.scene.name);
        PlayerPrefs.SetFloat("XCord", player.transform.position.x);
        PlayerPrefs.SetFloat("YCord", player.transform.position.y);
        PlayerPrefs.SetFloat("ZCord", player.transform.position.z);
        PlayerPrefs.SetInt("SaveFile", 1);
        PlayerPrefs.Save();
    }

    public void LoadPlayer()
    {
        if (PlayerPrefs.GetInt("SaveFile") == 1)
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("CurScene"));
            float pX = PlayerPrefs.GetFloat("XCord");
            float pY = PlayerPrefs.GetFloat("YCord");
            float pZ= PlayerPrefs.GetFloat("ZCord");
            player.transform.position = new Vector3(pX, pY, pZ);
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
