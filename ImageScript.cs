using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour

{
    public Image imageToChange;
    public Sprite hummingbird;
    public Sprite cat;
    public Sprite squirrel;
    public Sprite ati;
    public Sprite flower;
    public int chosenImage;
    public string animal = "";
    


    // Start is called before the first frame update
    void Start()
    {
        chosenImage = Random.Range(1,6);

        switch (chosenImage) {
            case 1:
                imageToChange.sprite = hummingbird;
                animal = "Hummingbird";
                break;
            case 2:
                imageToChange.sprite = cat;
                animal = "Cat";
                break;
            case 3:
                imageToChange.sprite = squirrel;
                animal = "Squirrel";
                break;
            case 4:
                imageToChange.sprite = ati;
                animal = "Dog";
                break;
            case 5:
                imageToChange.sprite = flower;
                animal = "Flower";
                break;
     
        }

         Debug.Log("The chosen image is" + chosenImage + " " + animal);

    }

}
