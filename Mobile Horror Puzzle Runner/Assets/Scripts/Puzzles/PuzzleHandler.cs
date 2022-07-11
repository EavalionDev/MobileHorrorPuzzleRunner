using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleHandler : MonoBehaviour
{
    public AudioSource speaker;
    public AudioClip keypadNormalSound, keypadRedSound, keypadGreenSound;
    public List<GameObject> mathPuzzles = new List<GameObject>();
    public List<GameObject> lightPuzzles = new List<GameObject>();
    public static bool newPuzzle, keyPadButtonPressed, redKeypadButtonPressed, greenKeypadButtonPressed;
    private GameObject chosenPuzzle;
    private int index;
    //make a list of categories when youve made them then randomly chose from it first, use bool to confirm chosen category

    private bool math, light;
    // Start is called before the first frame update
    void Start()
    {
        math = false;
        light = false;
        keyPadButtonPressed = false;
        redKeypadButtonPressed = false;
        greenKeypadButtonPressed = false;
        newPuzzle = false;
        //ChoosePuzzle();
    }

    // Update is called once per frame
    void Update()
    {
        //HAS A LIST OF A PUZZLE CATEGORIES, MATH PUZZLES, CODE PUZZLES ETC, RANDOMLY SELECTS ONE OF THE CATEGORIES THEN RANDOMLY SELECTS
        //ONE OF THE PUZZLES IN THAT CATEGORY, ONCE CHOSEN THE PUZZLE CANVAS IS MADE ACTIVE AND THE PREVIOUS IS DISABLED
        if (newPuzzle)
        {
            int index = Random.Range(0, 2);
            print(index);
            if (index == 0)
            {
                math = true;
                light = false;
            }
            else if (index == 1)
            {
                light = true;
                math = false;
            }
            ChoosePuzzle();
        }
        if (keyPadButtonPressed)
        {
            speaker.clip = keypadNormalSound;
            speaker.Play();
            keyPadButtonPressed = false;
        }
        if (greenKeypadButtonPressed)
        {
            speaker.clip = keypadGreenSound;
            speaker.Play();
            greenKeypadButtonPressed = false;
        }
        if (redKeypadButtonPressed)
        {
            speaker.clip = keypadRedSound;
            speaker.Play();
            redKeypadButtonPressed = false;
        }
    }
    void ChoosePuzzle()
    {
        newPuzzle = false;
        if (math)
        {
            index = Random.Range(0, mathPuzzles.Count);
            if (chosenPuzzle != null)
            {
                chosenPuzzle.SetActive(false);
            }
            chosenPuzzle = mathPuzzles[index];
            //chosenPuzzle = mathPuzzles[0];
            chosenPuzzle.SetActive(true);
            if (index == 0)
            {
                MathEasy.generatePuzzle = true;

            }
            else if (index == 1)
            {
                MathMedium.generatePuzzle = true;
            }
            else if (index == 3)
            {
                MathHard.generatePuzzle = true;
            }
            math = false;
        }
        else if (light)
        {
            index = Random.Range(0, lightPuzzles.Count);
            if (chosenPuzzle != null)
            {
                chosenPuzzle.SetActive(false);
            }
            chosenPuzzle = lightPuzzles[index];
            chosenPuzzle.SetActive(true);
            if (index ==0)
            {

            }
            else if (index == 1)
            {
                LightSequencePuzzle.generatePuzzle = true;
            }
            light = false;
        }
    }

    
}
