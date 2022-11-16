using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownMazeTeleporter : MonoBehaviour
{
    public float newX;
    public float newY;
    public GameObject player;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Vector2 tele = new Vector2(newX, newY);
            player.transform.position = tele;
        }
    }
}
