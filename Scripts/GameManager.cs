using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using System.Linq;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] public TMP_Text scoreText;
    [SerializeField] public TMP_Text msgText;
    [SerializeField] public float spawnRadiusFromObj; // spawn outside this radius of all objects (players and enemy)
    [SerializeField] public float sightRadius; // radius to disable spawns.
    [SerializeField] public float validRadius; // limit radius from player to spawn.
    
    private static TextMeshProUGUI uiscore; // CHANGE FROM STATIC
    public static int score; // CHANGE FROM STATIC
    private STAGE gameStage;
    private bool[] spawnsOnBoard;
    private Transform player;
    
    private enum STAGE
    {
        TOTURIAL,
        STAGE1
    };

    static GameManager instance;
    public static GameManager Instance {
        get {
            if (!instance) {
                instance = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        uiscore = scoreText.GetComponent<TextMeshProUGUI>();
        gameStage = STAGE.TOTURIAL;
        uiscore.text = "Score: 0";
        score = 0;
        player = Player.Instance.transform;
        // DisableAllFood();
        // SpawnPoints();
        //var type = msgText.GetComponent<"Type Out Script">();
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameStage)
        {
            case STAGE.TOTURIAL:
                
                
            case STAGE.STAGE1:
                break;
        }
    }

    public static void IncScore()
    {
        score++;
        uiscore.text = ("Score: " + score);
    }



    
    
    //find available pos to spawn.
    public Vector3 FindPosToSpawn()
    {
       
        Vector3 spawnPosition = (player.position + (validRadius * (Random.insideUnitSphere)));
        while (Vector3.Distance(spawnPosition, player.position) <= spawnRadiusFromObj)
        {
            
            spawnPosition = (player.position + (validRadius * (Random.insideUnitSphere)));
        }

        return spawnPosition;
    }
}
