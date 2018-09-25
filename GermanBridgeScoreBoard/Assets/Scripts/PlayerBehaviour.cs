using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{

    public class PlayerRound
    {
        public int playerId;
        public int bid;
        public int win;
        public int deltaScore = 0;
        public int totalScore = 0;

        public PlayerRound(int playerId, int bid)
        {
            this.playerId = playerId;
            this.bid = bid;
        }
    }

    public InputField inputFieldName;
    public InputField inputFieldBidTrick;
    public InputField inputFieldWinTrick;

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

    public void SetUpPlayer (int playerId)
    {
        playerName = inputFieldName.text;
        if (!string.IsNullOrEmpty(playerName))
        {
            this.playerId = playerId;
        }
    }

    public void SetPlayerBidTrick()
    {
        PlayerRound playerRound = new PlayerRound(this.playerId, Int32.Parse(inputFieldBidTrick.text));
        playerRounds.Push(playerRound);
    }

    public void SetPlayerWinTrick()
    {
        GetCurrPlayerRound().win = Int32.Parse(inputFieldWinTrick.text);
    }
    #endregion
}
