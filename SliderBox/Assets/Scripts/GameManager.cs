﻿using System;
using System.Threading;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool IsGameEnded = false;
    [SerializeField] float restartDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject player;
    public GameObject InfoPanel;
    public movement mvm;
    public bool flag = true;
    public AudioSource BGM;
    public GameObject GamePanel;
    public CPUPLAYERSCRIPT _AIPlayer;

    public void Start() {
        completeLevelUI.SetActive(false);
        GamePanel.SetActive(true);
        IsGameEnded = false;
        player.SetActive(false);
        _AIPlayer.enabled = false;
    }

    public void CompleteLevel()
    {
        InfoPanel.SetActive(false);
        completeLevelUI.SetActive(true);
        IsGameEnded = true;
        Invoke("next", 2f);
    }

    void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void BeginGame()
    {   BGM.Play();
        player.SetActive(true);
        //mvm.enabled = true;
        _AIPlayer.enabled = true;
    }

    public void EndGame()
    {
        if(IsGameEnded == false) 
        {
            BGM.Stop();
            print("Game Ended");

            IsGameEnded = true;
            if(flag)
                Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        //SceneManager.LoadScene("Scene1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
