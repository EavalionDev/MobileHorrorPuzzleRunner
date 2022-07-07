using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreHandler : MonoBehaviour
{
    public static bool addToDoorClearCount = false;
    public GameObject scoreCanvas;
    public Image canvasImage;
    public Text doorsClearedText, timeSurvivedText, scoreText, doorsClearedVal, timeSurvivedVal, overAllScoreVal;
    public GameObject restartButton, menuButton;
    public float multiplier, countUpSpeed;
    private int doorsCleared;
    private float timeSurvived, alphaVal, timeSurivivedNum, tempScore, overAllScore, doorsClearedNum;
    private bool displayedScore, doorCountUp, timeCountUp, scoreCountUp;
    // Start is called before the first frame update
    void Start()
    {
        tempScore = 0;
        timeSurivivedNum = 0;
        doorsClearedNum = 0;
        doorsCleared = 10;
        doorCountUp = false;
        timeCountUp = false;
        scoreCountUp = false;
        displayedScore = false;
        timeSurvived = 0;
        alphaVal = 0;
        if (scoreCanvas.activeSelf)
        {
            scoreCanvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!GhostMovement.playerCaught)
        {
            timeSurvived += Time.deltaTime;
        }

        if (addToDoorClearCount)
        {
            doorsCleared++;
            addToDoorClearCount = false;
        }
        if (GhostMovement.playerCaught)
        {
            if (!scoreCanvas.activeSelf)
            {
                scoreCanvas.SetActive(true);
            }
            //Fade in the alpha values
            if (alphaVal < 1)
            {
                alphaVal += Time.deltaTime / 2;
                Color newCol = canvasImage.color;
                newCol.a = alphaVal;
                canvasImage.color = newCol;
            }

            if (!displayedScore)
            {
                StartCoroutine(DispayStats());
            }
        }

        if (doorCountUp)
        {
            if (doorsClearedNum < doorsCleared)
            {
                doorsClearedNum += countUpSpeed * Time.deltaTime;
                doorsClearedVal.text = doorsClearedNum.ToString("0");
            }
            else
            {
                doorsClearedVal.text = doorsClearedNum.ToString("0");
                timeCountUp = true;
            }
        }

        if (timeCountUp)
        {
            if (timeSurivivedNum < timeSurvived)
            {
                timeSurivivedNum += countUpSpeed * 1.25f * Time.deltaTime;
                timeSurvivedVal.text = timeSurivivedNum.ToString("0.00");
            }
            else
            {
                timeSurvivedVal.text = timeSurivivedNum.ToString("0.00");
                //scoreCountUp = true;
            }
        }
        if (scoreCountUp)
        {
            //THIS WORKS ON PC BUT IS CLUNKY AND STOPS/STARTS ON THE PHONE, CAN USE AGAIN BUT NEED TO FIGURE OUT WHY ITS NOT SMOOTH

            //if (tempScore < overAllScore)
            //{
            //    tempScore += countUpSpeed * 1.25f * Time.deltaTime;
            //    overAllScoreVal.text = tempScore.ToString("0");
            //}
        }
    }
    IEnumerator DispayStats()
    {
        displayedScore = true;
        yield return new WaitForSeconds(3f);
        doorsClearedText.enabled = true;
        yield return new WaitForSeconds(0.5f);
        doorsClearedVal.enabled = true;
        if (doorsCleared == 0)
        {
            doorsClearedVal.text = "0";
        }
        else
        {
            doorCountUp = true;
        }
        yield return new WaitForSeconds(1f);
        timeSurvivedText.enabled = true;
        yield return new WaitForSeconds(0.5f);
        timeSurvivedVal.enabled = true;
        yield return new WaitForSeconds(1f);
        scoreText.enabled = true;
        yield return new WaitForSeconds(0.5f);
        overAllScoreVal.enabled = true;
        overAllScore = doorsCleared * timeSurvived * multiplier;
        if (doorsCleared == 0)
        {
            overAllScoreVal.text = "0";
        }
        else
        {
            overAllScoreVal.text = overAllScore.ToString("0");
        }
        yield return new WaitForSeconds(1f);
        restartButton.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        menuButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Prototype");
    }
    public void MenuButton()
    {
        print("GO TO MENU");
    }

}
