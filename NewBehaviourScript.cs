using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public string buttonLabel = "";
    public ImageScript myScript;

    void Start()
    {
        myScript = GameObject.FindGameObjectWithTag("Image").GetComponent<ImageScript>();

    }

    public void getLabel() {
        buttonLabel = GetComponentInChildren<Text>().text;
        Debug.Log(buttonLabel);
    }

    public void winCondition() {
        int picNum = myScript.chosenImage;
        if (picNum == 1 && buttonLabel == "Hummingbird"
            || picNum == 2 && buttonLabel == "Cat"
            || picNum == 3 && buttonLabel == "Squirrel"
            || picNum == 4 && buttonLabel == "Dog"
            || picNum == 5 && buttonLabel == "Flower")
        {
            Debug.Log("Winner");
            SceneManager.LoadScene("Scene2");

        }
        else {
            Debug.Log("Loser");
            SceneManager.LoadScene("loser");
        
        }
    
    
    }
}
