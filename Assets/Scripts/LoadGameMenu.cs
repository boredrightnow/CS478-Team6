using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameMenu : MonoBehaviour
{

    public GameObject Can2;

    // Start is called before the first frame update
    void Start()
    {
        Can2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseUp()
    {
        Can2.gameObject.SetActive(true);
    }
}
