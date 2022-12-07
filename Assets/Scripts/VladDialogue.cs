using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VladDialogue : MonoBehaviour
{
    public GameObject DialogueWindow;
    public GameObject textbox;
    public GameObject NPCname;
    private string dialogue;
    private int panel = 1;
    private bool talking = false;
    // Start is called before the first frame update
    void Start()
    {
        DialogueWindow.gameObject.SetActive(false);
        textbox.GetComponent<TMP_InputField>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            if (talking == true)
            {
                DialogueWindow.gameObject.SetActive(false);
                if (panel < 5)
                {
                    panel++;

                    StartCoroutine("Dialogue");
                }
                else
                {
                    SceneManager.LoadScene("TownFinal");
                }
            }
        }
    }
    IEnumerator Dialogue()
    {
        switch (panel)
        {
            case 0:
                DialogueWindow.gameObject.SetActive(false);
                break;
            case 1:
                dialogue = "Wait! How did you get through the maze?";
                NPCname.GetComponent<TMP_Text>().text = "Vlad";
                textbox.GetComponent<TMP_Text>().text = dialogue;
                break;
            case 2:
                DialogueWindow.gameObject.SetActive(true);
                dialogue = "Nevermind that! You still can't have MY candy!";
                NPCname.GetComponent<TMP_Text>().text = "Vlad";
                textbox.GetComponent<TMP_Text>().text = dialogue;
                break;
            case 3:
                DialogueWindow.gameObject.SetActive(true);
                dialogue = "Why should I give it back? They always forget about me every Halloween and keep the candy to themselves!";
                NPCname.GetComponent<TMP_Text>().text = "Vlad";
                textbox.GetComponent<TMP_Text>().text = dialogue;
                break;
            case 4:
                DialogueWindow.gameObject.SetActive(true);
                dialogue = "What do you mean they didn't forget? They tried sending me letters, and I tossed it thinking it was bills?";
                NPCname.GetComponent<TMP_Text>().text = "Vlad";
                textbox.GetComponent<TMP_Text>().text = dialogue;
                break;
            case 5:
                DialogueWindow.gameObject.SetActive(true);
                dialogue = "I guess that does sound like me.. Maybe you're right-- I guess I should return the candy.";
                NPCname.GetComponent<TMP_Text>().text = "Vlad";
                textbox.GetComponent<TMP_Text>().text = dialogue;
                break;
            default:
                break;
        }
        yield return null;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueWindow.gameObject.SetActive(true);
            talking = true;

            StartCoroutine("Dialogue");



        }
    }
}
