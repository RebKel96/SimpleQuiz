using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{

    public ImageScript myScript;
    // Start is called before the first frame update
    void Start()
    {
        myScript = GameObject.FindGameObjectWithTag("Image").GetComponent<ImageScript>();


    }


   /* public void correctAnswer()
    {
        //make it so if chosen sprite name equals label name(with both values being
        //converted to strings ignoring capitalization) you win and get my email.
        //else, bring you to losing screen that tells the user they're wrong and to refresh

        int num = myScript.chosenImage;

        if (num == 1 && labels == "Hummingbird"
            || num == 2 && labels == "Cat"
            || num == 3 && labels == "Squirrel"
            || num == 4 && labels == "Dog"
            || num == 5 && labels == "Flower")
        {
            SceneManager.LoadScene("Scene2");
        }
    }*/
}
