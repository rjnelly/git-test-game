using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    Player player;
    public GameObject startMenu;
    public GameObject gameUI;

    public Text display;
    public Text option1;
    public Text option2;
    public Text option3;
    public Text option4;

    int location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        gameUI.SetActive(true);

        player = new Player();
        goToLocation(0);
    }

    public void goToStart()
    {
        display.text = GameData.descriptions[0];
        option1.text = GameData.options[0,0];
        option2.text = GameData.options[0,1];
        option3.text = GameData.options[0,2];
        option4.text = GameData.options[0,3];
    }

    public void goToLocation(int newLoc)
    {
        location = newLoc;
        display.text = GameData.descriptions[location];
        option1.text = GameData.options[location, 0];
        option2.text = GameData.options[location, 1];
        option3.text = GameData.options[location, 2];
        option4.text = GameData.options[location, 3];
    }

    public void optionSelected(int index)
    {
        if(location == 0)
        {
            if(index == 0)
            {
                goToLocation(1);
            }
            else if(index == 1)
            {
                EndGame();
            }
            else if(index == 2)
            {
                goToLocation(2);
            }
            else { }
        }
        else if (location == 1)
        {
            if (index == 0)
            {
                goToLocation(1);
            }
            else if (index == 1)
            {
                EndGame();
            }
            else if (index == 2)
            {

            }
            else { }
        }


    }

    public void EndGame()
    {
        Debug.Log("Game Over " + location);
    }
}
