using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{

    public static Scoreboard Instance;

    int p1Score;
    int p2Score;
    public int maxScore;
    public string p1WinMessage;
    public string p2WinMessage;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI winMessageText;

    private void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckWin()
    {
        if(p1Score >= maxScore)
        {
            winMessageText.text = p1WinMessage;
        }
        else if(p2Score >= maxScore)
        {
            winMessageText.text = p2WinMessage;
        }
        else
        {
            BallSpawner.Instance.SpawnBall();
        }
    }

    public void GivePointToP1()
    {
        //this is a quick way to add one, you can also write it as:
        //p1Score +=1; to add one point, or p1Score += 10; to add 10, ect
        p1Score++;
        p1ScoreText.SetText(p1Score.ToString());
        //.ToString converts something into a string
        CheckWin();
    } 
    
    public void GivePointToP2()
    {
        p2Score++;
        p2ScoreText.SetText(p2Score.ToString());
        CheckWin();
    }

}
