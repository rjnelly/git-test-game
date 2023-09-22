using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject gameUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            startMenu.SetActive(true);
            gameUI.SetActive(false);
            Debug.Log("Escaped Pressed");
        }
    }

    public void StartGame()
    {
        Player player = new Player();
    }

    public void Quit()
    {
        Application.Quit();
    }

}
