using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnswerChoices : MonoBehaviour

{
    public Button[] buttons;
    public string[] labels;
    public ImageScript myScript;
    public NewBehaviourScript theLabel;
    public bool answerExists = false;
    // Start is called before the first frame update
    void Start()
    {
        myScript = GameObject.FindGameObjectWithTag("Image").GetComponent<ImageScript>();
        theLabel = GameObject.FindGameObjectWithTag("Answer").GetComponent<NewBehaviourScript>();
        randomizeButtons();
    }

    public void randomizeButtons() {
        // Shuffle the labels array
        for (int i = 0; i < labels.Length; i++)
        {
            string temp = labels[i];
            int randomIndex = Random.Range(i, labels.Length);
            labels[i] = labels[randomIndex];
            labels[randomIndex] = temp;
        }

        // Assign each label to a button
        for (int i = 0; i < buttons.Length; i++)
        {
            Text buttonText = buttons[i].GetComponentInChildren<Text>();
            if (buttonText != null) // make sure the button has TMP text
            {
                buttonText.text = labels[i];
            }

        }

        //make sure existing answer is one of the buttons
        for (int i = 0; i < buttons.Length; i++)
        {
            Text buttonText = buttons[i].GetComponentInChildren<Text>();
            if (buttonText.text == myScript.animal) // make sure the button has TMP text
            {
                answerExists = true;
            }

        }

        //if it is not, assign the real answer to a random button
        if (!answerExists)
        {
            int rand = Random.Range(0,buttons.Length);
            Text randButton = buttons[rand].GetComponentInChildren<Text>();
            randButton.text = myScript.animal;

        }

    }

}
