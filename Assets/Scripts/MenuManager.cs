using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject OptionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        OptionsMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsMenu.gameObject.SetActive(!OptionsMenu.gameObject.activeSelf);
        }
        
    }
}
