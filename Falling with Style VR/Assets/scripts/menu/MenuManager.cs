﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    /// <summary>
    /// decides which levels are visibly active in main menu and updates score board
    /// </summary>
    public GameObject[] levels;
    public Text scoreBoard;
    private void Awake()
    {
        for (int i = 1; i < levels.Length; i++) {
            if (GameManager.levelChart[i - 1] <= 0)
                levels[i].SetActive(false);
            else
                Debug.Log(i);
        }

        scoreBoard.text = "";
        for (int i = 0; i<GameManager.levelChart.Length; i++) {
            Debug.Log(GameManager.levelChart[i]);
            if (GameManager.levelChart[i] > 0)
                scoreBoard.text += "Level " + (i + 1).ToString() + ": " + GameManager.levelChart[i].ToString() + "\n";
        }
    }

}
