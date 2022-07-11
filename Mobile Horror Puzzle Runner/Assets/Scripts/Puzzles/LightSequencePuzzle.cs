using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSequencePuzzle : MonoBehaviour
{
    public List<Image> lights = new List<Image>();
    public static bool generatePuzzle;
    private bool canInteract;
    private Image selectedButton, chosenButtonForSequence;
    public List<Image> sequnce = new List<Image>();

    // Start is called before the first frame update
    void Start()
    {
        canInteract = false;
        generatePuzzle = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (generatePuzzle)
        {
            StartCoroutine(StartSequence());
            generatePuzzle = false;
            if (sequnce.Count > 0)
            {
                sequnce.Clear();
            }
        }

    }
    void ClearSequence()
    {
        sequnce.Clear();
    }
    IEnumerator StartSequence()
    {
        //URGENT NOTE: FOR SOME REASON THE FIRST BUTTON TP LIGHT UP IS NOT ADDED TO THE LIST AND THE 2ND WILL BE THE FIRST ADDED

        int numberOfLights = Random.Range(4, 7);
        int numTest = 0;
        for (int i = 0; i < numberOfLights; i++)
        {
            print("BUTTON IS LIT");
            int index = Random.Range(0, lights.Count);
            chosenButtonForSequence = lights[index];
            sequnce.Add(chosenButtonForSequence);
            yield return new WaitForSeconds(0.3f);
            chosenButtonForSequence.color = Color.red;
            yield return new WaitForSeconds(0.3f);
            chosenButtonForSequence.color = Color.white;
            numTest++;
            print("NUM TEST " + numTest);
        }
        //while (numberOfLights > 0)
        //{
        //    print("BUTTON IS LIT");
        //    int index = Random.Range(0, lights.Count);
        //    chosenButtonForSequence = lights[index];
        //    sequnce.Add(chosenButtonForSequence);
        //    yield return new WaitForSeconds(0.3f);
        //    chosenButtonForSequence.color = Color.red;
        //    yield return new WaitForSeconds(0.3f);
        //    chosenButtonForSequence.color = Color.white;
        //    numTest++;
        //    print("NUM TEST " + numTest);
        //}
        canInteract = true;
    }
    IEnumerator ButtonPressed()
    {
        if (canInteract)
        {
            if (sequnce.Count > 1)
            {
                if (selectedButton == sequnce[0])
                {
                    PuzzleHandler.keyPadButtonPressed = true;
                    print("CORRECT");
                    selectedButton.color = Color.green;
                    yield return new WaitForSeconds(0.15f);
                    selectedButton.color = Color.white;
                    sequnce.Remove(selectedButton);
                }
                else
                {
                    PuzzleHandler.redKeypadButtonPressed = true;
                    canInteract = false;
                    StartCoroutine(WrongChoice());
                }
            }
            else
            {
                //CHANGE SOUND TO PUZZLE COMPLETE SOUND WHEN IMPLEMENTED
                PuzzleHandler.greenKeypadButtonPressed = true;
                sequnce.Clear();
                if (DoorStopCol.atDoor)
                {
                    DoorStopCol.atDoor = false;
                }
            }
        }
    }
    IEnumerator WrongChoice()
    {
        print("WRONG");
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].color = Color.red;
        }
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].color = Color.white;
        }
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].color = Color.red;
        }
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].color = Color.white;
        }
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].color = Color.red;
        }
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].color = Color.white;
        }
        yield return new WaitForSeconds(0.3f);
        ClearSequence();
        StartCoroutine(StartSequence());
    }
    public void LightButtonOne()
    {
        selectedButton = lights[0];
        StartCoroutine(ButtonPressed());
    }
    public void LightButtonTwo()
    {
        selectedButton = lights[1];
        StartCoroutine(ButtonPressed());
    }
    public void LightButtonThree()
    {
        selectedButton = lights[2];
        StartCoroutine(ButtonPressed());
    }
    public void LightButtonFour()
    {
        selectedButton = lights[3];
        StartCoroutine(ButtonPressed());

    }
    public void LightButtonFive()
    {
        selectedButton = lights[4];
        StartCoroutine(ButtonPressed());
    }
    public void LightButtonSix()
    {
        selectedButton = lights[5];
        StartCoroutine(ButtonPressed());
    }
    public void LightButtonSeven()
    {
        selectedButton = lights[6];
        StartCoroutine(ButtonPressed());
    }
    public void LightButtonEight()
    {
        selectedButton = lights[7];
        StartCoroutine(ButtonPressed());
    }
    public void LightButtonNine()
    {
        selectedButton = lights[8];
        StartCoroutine(ButtonPressed());
    }

}
