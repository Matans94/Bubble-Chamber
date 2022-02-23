using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text hScoreText;
    [SerializeField] string sceneToLoad = "SampleScene";
    [SerializeField] private GameObject playBtm, exitBtm;
    static public int highestScore;
    private int arrow;
    private int menuSize = 2;

    private void Awake()
    {
        highestScore = (highestScore < GameManager.score) ? GameManager.score : highestScore;
        hScoreText.GetComponent<TextMeshProUGUI>().text = "Highest Score: " + highestScore;
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            arrow = arrow + 1 > menuSize ? arrow : arrow++;
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            arrow = arrow - 1 < 0 ? arrow : arrow--;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            //close the app
        }
    }

    private void Update()
    {
        switch (arrow)
        {
            case 0:
                
                
                break;
            case 1:
                break;
        }
    }

    public void Play() {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Exit() {
        Application.Quit();
    }

    public void Credits() {

    }
}
