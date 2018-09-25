using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public List<PlayerBehaviour> players;

    private int roundNum = 1;

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

    #region Get Set Functions
    public int GetCurrRoundNum()
    {
        return roundNum;
    }
    #endregion

    #region OnBtnClick
    public void OnGameStartBtnClick()
    {

    }

    public void OnRoundStartBtnClick()
    {
        foreach (var player in players)
        {
            player.SetPlayerBidTrick();
        }

        // Set socre board
    }

    public void OnRoundFinishBtnClick()
    {
        foreach (var player in players)
        {
            player.SetPlayerWinTrick();
        }

        // Update score board

        roundNum++;
    }
    #endregion
}
