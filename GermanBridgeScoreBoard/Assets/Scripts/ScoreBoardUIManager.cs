using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardUIManager : MonoBehaviour
{

    public static ScoreBoardUIManager Instance;

    [Header("Score Bar Header")]
    public Text roundTxt;
    public Text[] playerNamesTxt;

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
}
