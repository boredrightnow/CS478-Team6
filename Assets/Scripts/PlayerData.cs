using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position;
    public List<string> sceneHist;
    public PlayerControl IhateSerialization;
    public SceneChanger scenelistgod;

    public PlayerData()
    {
        

        sceneHist = scenelistgod.GetSceneHistory();


        //IhateSerialization = GameObject.FindObjectOfType(typeof(PlayerControl)) as PlayerControl;
        position = IhateSerialization.GetPosition();

        
    }
}
