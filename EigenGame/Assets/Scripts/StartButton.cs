using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button startButton;
    private GameManager gamemanger;
    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
        gamemanger = GameObject.Find("Gamemanager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void loadGame()
    {
        gamemanger.startGame();
    }
    
}
