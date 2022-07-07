using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleHandler : MonoBehaviour
{
    public List<GameObject> mathPuzzles = new List<GameObject>();
    public static bool newPuzzle;
    private GameObject chosenPuzzle;
    private int index;
    //make a list of categories when youve made them then randomly chose from it first, use bool to confirm chosen category

    private bool math = true;
    // Start is called before the first frame update
    void Start()
    {
        newPuzzle = false;
        ChoosePuzzle();
    }

    // Update is called once per frame
    void Update()
    {
        //HAS A LIST OF A PUZZLE CATEGORIES, MATH PUZZLES, CODE PUZZLES ETC, RANDOMLY SELECTS ONE OF THE CATEGORIES THEN RANDOMLY SELECTS
        //ONE OF THE PUZZLES IN THAT CATEGORY, ONCE CHOSEN THE PUZZLE CANVAS IS MADE ACTIVE AND THE PREVIOUS IS DISABLED
        if (newPuzzle)
        {
            ChoosePuzzle();
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
        }
    }

    
}
