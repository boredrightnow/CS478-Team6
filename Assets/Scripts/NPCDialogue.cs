using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    public GameObject DialogueWindow;
    public GameObject textbox;
    public GameObject NPCname;
    public int NPC;
    private string dialogue;
    // Start is called before the first frame update
    void Start()
    {
        DialogueWindow.gameObject.SetActive(false);
        textbox.GetComponent<TMP_InputField>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DialogueWindow.gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueWindow.gameObject.SetActive(true);

            switch (NPC)
            {
                case 1:
                    dialogue = "That rotten Vlad the inhaler took everyone’s candy! I don’t see Halloween making it past midnight. If only some big, strong, handsome heroine could sweep us off our feet and save Halloween… ";
                    NPCname.GetComponent<TMP_Text>().text = "Masha";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 2:
                    dialogue = "Mhhm something about these leaves..... The mud smells deeper than it seems. Walk into the wrong pile and who knows where you'll find yourself.";
                    NPCname.GetComponent<TMP_Text>().text = "Mud";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 3:
                    dialogue = "GRRR MFFHMH GURGLE (PLEASE SAVE HALLOWEEN!!!)";
                    NPCname.GetComponent<TMP_Text>().text = "Gator";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
            }


           
        }
    }
}
