using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MathMedium : MonoBehaviour
{
    public List<string> numbersInputted = new List<string>();
    public Text questionText, answerSlot1, answerSlot2, answerSlot3, answerSlot4, answerSlot5, answerSlot6, answerSlot7, minusSlot;
    public static bool generatePuzzle;
    private Text previousAnswerText;
    private bool setQuestion, listContainsMinus;
    private int answer, answerSlotNum;
    // Start is called before the first frame update
    void Start()
    {
        generatePuzzle = false;
        answerSlotNum = 1;
        setQuestion = false;
        listContainsMinus = false;
    }

    // Update is called once per frame
    void Update()
    {
        //print(answerSlotNum);
        //answerText.text = "" + inputtedAnswer;
        if (generatePuzzle)
        {
            ClearPad();
            int numberOne = Random.Range(100, 501);
            int numberTwo = Random.Range(100, 501);
            int action = Random.Range(0, 2);
            if (action == 0)
            {
                answer = numberOne + numberTwo;
                questionText.text = " " + numberOne + " + " + numberTwo + "=";
                print(answer);
            }
            else if (action == 1)
            {
                answer = numberOne - numberTwo;
                questionText.text = " " + numberOne + " - " + numberTwo + "=";
                print(answer);
            }
            setQuestion = true;
            generatePuzzle = false;
        }
    }
    void ClearPad()
    {
        answerSlotNum = 1;
        answerSlot1.text = "";
        answerSlot2.text = "";
        answerSlot3.text = "";
        answerSlot4.text = "";
        answerSlot5.text = "";
        answerSlot6.text = "";
        answerSlot7.text = "";
        minusSlot.text = "";
        numbersInputted.Clear();
    }
    //Keypad Functionality
    public void Zero()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "0";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "0";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "0";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "0";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "0";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "0";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "0";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void One()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "1";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "1";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "1";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "1";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "1";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "1";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "1";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Two()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "2";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "2";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "2";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "2";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "2";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "2";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "2";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Three()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "3";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "3";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "3";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "3";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "3";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "3";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "3";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Four()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "4";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "4";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "4";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "4";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "4";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "4";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "4";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Five()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "5";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "5";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "5";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "5";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "5";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "5";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "5";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Six()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "6";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "6";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "6";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "6";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "6";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "6";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "6";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Seven()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "7";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "7";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "7";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "7";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "7";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "7";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "7";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Eight()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "8";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "8";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "8";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "8";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "8";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "8";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "8";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void Nine()
    {
        if (answerSlotNum == 1)
        {
            answerSlot1.text = "9";
            numbersInputted.Add(answerSlot1.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 2)
        {
            answerSlot2.text = "9";
            numbersInputted.Add(answerSlot2.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 3)
        {
            answerSlot3.text = "9";
            numbersInputted.Add(answerSlot3.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 4)
        {
            answerSlot4.text = "9";
            numbersInputted.Add(answerSlot4.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 5)
        {
            answerSlot5.text = "9";
            numbersInputted.Add(answerSlot5.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 6)
        {
            answerSlot6.text = "9";
            numbersInputted.Add(answerSlot6.text);
            answerSlotNum++;
        }
        else if (answerSlotNum == 7)
        {
            answerSlot7.text = "9";
            numbersInputted.Add(answerSlot7.text);
            answerSlotNum++;
        }
    }
    public void GreenButton()
    {
        string total = string.Empty;
        for (int i = 0; i < numbersInputted.Count; i++)
        {
            total = total + numbersInputted[i];
        }
        if (minusSlot.text == "-")
        {
            int numberSubmitted;
            bool convertNum = int.TryParse(total, out numberSubmitted);
            if (convertNum)
            {
                numberSubmitted = -numberSubmitted;
                if (numberSubmitted == answer)
                {
                    print("CORRECT");
                    ClearPad();
                    if (DoorStopCol.atDoor)
                    {
                        DoorStopCol.atDoor = false;
                    }
                }
                else
                {
                    print("WRONG");
                    ClearPad();
                }
                print(numberSubmitted);
            }
            else
            {
                Debug.Log("COULD NOT CONVERT STRING TO INT");
            }
        }
        else
        {
            // int numberSubmitted = int.Parse(total);
            int numberSubmitted;
            bool convertNum = int.TryParse(total, out numberSubmitted);
            if (convertNum)
            {
                if (numberSubmitted == answer)
                {
                    print("CORRECT");
                    ClearPad();
                    if (DoorStopCol.atDoor)
                    {
                        DoorStopCol.atDoor = false;
                    }
                }
                else
                {
                    print("WRONG");
                    ClearPad();
                }
                print(numberSubmitted);
            }
            else
            {
                Debug.Log("COULD NOT CONVERT STRING TO INT");
            }
        }
    }
    public void RedButton()
    {
        ClearPad();
    }
    public void MinusButton()
    {
        if (minusSlot.text == "")
        {
            print("ADD MINUS");
            minusSlot.text = "-";
        }
        else if (minusSlot.text == "-")
        {
            print("TAKE AWAY MINUS");
            minusSlot.text = "";
        }
    }
}
