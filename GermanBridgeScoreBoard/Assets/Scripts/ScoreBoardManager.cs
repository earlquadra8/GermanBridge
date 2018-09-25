using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardManager : MonoBehaviour
{

    public static ScoreBoardManager Instance;

    public GameObject scoreBoard;
    public GameObject scoreBarPrefab;
    private Stack<ScoreBar> scoreBars = new Stack<ScoreBar>();
    #region Unity Mono
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

    void Update()
    {

    }
    #endregion

    public void AddScoreBar(int roundNum)
    {
        scoreBars.Push(Instantiate(scoreBarPrefab, scoreBoard.transform).GetComponent<ScoreBar>());
        scoreBars.Peek().roundNumTxt.text = roundNum.ToString("00");
    }

    public void UpdateScoreBar(PlayerBehaviour.PlayerRound playerRound)
    {
        playerRound.deltaScore = CalculateScore(playerRound.bid, playerRound.win);
        playerRound.totalScore += playerRound.deltaScore;
        scoreBars.Peek().playerScoresTxt[playerRound.playerId].text = playerRound.totalScore.ToString();
    }

    private int CalculateScore(int bid, int win)
    {
        int deltaScore;
        if (bid == win)
        {
            deltaScore = 10 + win ^ 2;
        } else
        {
            deltaScore = -1 * (Mathf.Abs(win - bid)) ^ 2;
        }

        return deltaScore;
    }
}
