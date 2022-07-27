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


    private bool sequence, lightSequence;
    // Start is called before the first frame update
    void Start()
    {
        lightSequence = false;
        sequence = false;
        canInteract = false;
        generatePuzzle = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (generatePuzzle)
        {
            //StartCoroutine(StartSequence());
            sequence = true;
            generatePuzzle = false;
            if (sequnce.Count > 0)
            {
                sequnce.Clear();
            }
        }

        if (sequence)
        {
            //The amount of lights that will be used for the sequence 
            int numberOfLights = Random.Range(4, 7);
            //Randomly select lights to add to the sequence
            while (numberOfLights > 0)
            {
                int index = Random.Range(0, lights.Count);
                chosenButtonForSequence = lights[index];
                sequnce.Add(chosenButtonForSequence);
                numberOfLights--;
            }
            //Once the list for the sequence is made, start the coroutine that lights them
            StartCoroutine(StartSequence());
            sequence = false;
        }
    }
    void ClearSequence()
    {
        sequnce.Clear();
    }
    IEnumerator StartSequence()
    {
        //iterates through the sequence and lights each light for 0.3 seconds then turns it back off
        int count = 0;
        while (count < sequnce.Count)
        {
            chosenButtonForSequence = sequnce[count];
            yield return new WaitForSeconds(0.3f);
            chosenButtonForSequence.color = Color.red;
            yield return new WaitForSeconds(0.3f);
            chosenButtonForSequence.color = Color.white;
            count++;
        }
        //player can now interact with the board to try and copy the sequence
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
        sequence = true;
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
