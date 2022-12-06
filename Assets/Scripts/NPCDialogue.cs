using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Return))
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
                case 4:
                    dialogue =  "I’m not the monster you're looking for! You should turn back.";
                    NPCname.GetComponent<TMP_Text>().text = "Yung Mummy";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 5:
                    dialogue = "This isn’t the path you’re looking for. Move along.";
                    NPCname.GetComponent<TMP_Text>().text = "Frankfurt";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 6:
                    dialogue = "It’s dangerous to go alone, go find a better path.";
                    NPCname.GetComponent<TMP_Text>().text = "Clawden";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 7:
                    dialogue = "C'mon now... you'll get there.... eventually.. The trees aren't as thick as they look..";
                    NPCname.GetComponent<TMP_Text>().text = "Mumopatra";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 8:
                    dialogue = "Hehe, I guess I should open the way for you.";
                    NPCname.GetComponent<TMP_Text>().text = "Franky";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 9:
                    dialogue = "MHHFMH AHHH GAGHHAA GRRR (GOD I'M LOST IN HERE TOO)";
                    NPCname.GetComponent<TMP_Text>().text = "Gator";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 10:
                    dialogue = "Ya know you can just walk right into any o' our homes! We don't bite . . tooooo hard.";
                    NPCname.GetComponent<TMP_Text>().text = "Millipede";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
                case 11:
                    dialogue = "It’s dangerous to go alone, go find a better path.";
                    NPCname.GetComponent<TMP_Text>().text = "Gator";
                    textbox.GetComponent<TMP_Text>().text = dialogue;
                    break;
            }


           
        }
    }
}
