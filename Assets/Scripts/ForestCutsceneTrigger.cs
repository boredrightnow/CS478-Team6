using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestCutsceneTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public int rightNPC;
    bool collided;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)&&collided==true)
        {
            if (rightNPC == 0)
            {
                Vector2 tele = new Vector2(-13, -13);
                player.transform.position = tele;
            }
            else
            {
                Vector2 tele = new Vector2(6, 17);
                player.transform.position = tele;
            }
            collided = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collided = true;
        }
    }
}
