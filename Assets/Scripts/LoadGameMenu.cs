using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameMenu : MonoBehaviour
{

    public GameObject NGame;
    public GameObject LGame;
    public GameObject CLoad;

    // Start is called before the first frame update
    void Start()
    {
        NGame.gameObject.SetActive(false);
        LGame.gameObject.SetActive(false);
        CLoad.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseUp()
    {
        NGame.gameObject.SetActive(true);
        LGame.gameObject.SetActive(true);
        CLoad.gameObject.SetActive(true);
    }
}
