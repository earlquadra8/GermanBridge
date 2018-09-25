using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour {

    public class PlayerRound
    {
        public int playerId;
        public int bid;
        public int win;
        public int deltaScore;

        public PlayerRound(int playerId, int bid)
        {
            this.playerId = playerId;
            this.bid = bid;
            this.win = 0;
            this.deltaScore = 0;
        }
    }

    public InputField inputFieldName;
    public InputField inputFieldBidTrick;
    public InputField inputFieldWinTrick;

    public GameObject setupConfirmBtn;

    private int playerId;
    private string playerName;
    private int playerCurrBid;

    private Stack<PlayerRound> playerRounds = new Stack<PlayerRound>();

    #region Unity Mono
    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
    #endregion

    #region Get Set Functions
    public void SetPlayerId (int playerId)
    {
        this.playerId = playerId;
    }

    public PlayerRound GetCurrPlayerRound ()
    {
        return playerRounds.Peek();
    }

    public void SetPlayerWinTrick()
    {
        GetCurrPlayerRound().win = Int32.Parse(inputFieldWinTrick.text);
    }
    #endregion

    #region OnBtnClick
    public void OnPlayerSetUpBtnClick ()
    {
        playerName = inputFieldName.text;
        if (!string.IsNullOrEmpty(playerName))
        {
            setupConfirmBtn.SetActive(false);
            // Setup playerId
        }
    }

    public void OnPlayerBidBtnClick ()
    {
        PlayerRound playerRound = new PlayerRound(this.playerId, Int32.Parse(inputFieldBidTrick.text));
        playerRounds.Push(playerRound);
        // Show score board
    }

    //public void OnPlayerWinBtnClick ()
    //{
    //    playerRounds.Peek().win = Int32.Parse(inputFieldWinTrick.text);
    //    // Update score board
    //}
    #endregion
}
