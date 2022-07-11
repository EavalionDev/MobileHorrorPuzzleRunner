using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightsOne : MonoBehaviour
{
    public Image lightOne, lightTwo, lightThree, lightFour, lightFive, lightSix, lightSeven, lightEight, lightNine;
    public static bool generatePuzzle;
    private List<Image> litButtons = new List<Image>();
    private int lightCount;
    // Start is called before the first frame update
    void Start()
    {
        generatePuzzle = false;
        lightCount = 0;
        ClearPad();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightCount == 9)
        {
            //CHANGE SOUND TO PUZZLE COMPLETE SOUND WHEN IMPLEMENTED
            PuzzleHandler.greenKeypadButtonPressed = true;
            ClearPad();
            if (DoorStopCol.atDoor)
            {
                DoorStopCol.atDoor = false;
            }
            lightCount = 0;
        }
        if (generatePuzzle)
        {
            ClearPad();
            generatePuzzle = false;
        }
    }
    void ClearPad()
    {
        foreach  (Image light in litButtons)
        {
            light.color = Color.white;
        }
    }
    public void LightButtonOne()
    {
        if (lightOne.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightOne))
            {
                litButtons.Add(lightOne);
            }
            lightOne.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightOne))
            {
                litButtons.Remove(lightOne);
            }
            lightOne.color = Color.white;
            lightCount--;
        }
    }
    public void LightButtonTwo()
    {
        if (lightTwo.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightTwo))
            {
                litButtons.Add(lightTwo);
            }
            lightTwo.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightTwo))
            {
                litButtons.Remove(lightTwo);
            }
            lightTwo.color = Color.white;
            lightCount--;
        }
    }
    public void LightButtonThree()
    {
        if (lightThree.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightThree))
            {
                litButtons.Add(lightThree);
            }
            lightThree.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightThree))
            {
                litButtons.Remove(lightThree);
            }
            lightThree.color = Color.white;
            lightCount--;
        }
    }
    public void LightButtonFour()
    {
        if (lightFour.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightFour))
            {
                litButtons.Add(lightFour);
            }
            lightFour.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightFour))
            {
                litButtons.Remove(lightFour);
            }
            lightFour.color = Color.white;
            lightCount--;
        }

    }
    public void LightButtonFive()
    {
        if (lightFive.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightFive))
            {
                litButtons.Add(lightFive);
            }
            lightFive.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightFive))
            {
                litButtons.Remove(lightFive);
            }
            lightFive.color = Color.white;
            lightCount--;
        }
    }
    public void LightButtonSix()
    {
        if (lightSix.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightSix))
            {
                litButtons.Add(lightSix);
            }
            lightSix.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightSix))
            {
                litButtons.Remove(lightSix);
            }
            lightSix.color = Color.white;
            lightCount--;
        }
    }
    public void LightButtonSeven()
    {
        if (lightSeven.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightSeven))
            {
                litButtons.Add(lightSeven);
            }
            lightSeven.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightSeven))
            {
                litButtons.Remove(lightSeven);
            }
            lightSeven.color = Color.white;
            lightCount--;
        }
    }
    public void LightButtonEight()
    {
        if (lightEight.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightEight))
            {
                litButtons.Add(lightEight);
            }
            lightEight.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightEight))
            {
                litButtons.Remove(lightEight);
            }
            lightEight.color = Color.white;
            lightCount--;
        }
    }
    public void LightButtonNine()
    {
        if (lightNine.color != Color.green)
        {
            PuzzleHandler.keyPadButtonPressed = true;
            if (!litButtons.Contains(lightNine))
            {
                litButtons.Add(lightNine);
            }
            lightNine.color = Color.green;
            lightCount++;
        }
        else
        {
            PuzzleHandler.redKeypadButtonPressed = true;
            if (litButtons.Contains(lightNine))
            {
                litButtons.Remove(lightNine);
            }
            lightNine.color = Color.white;
            lightCount--;
        }
    }
}
