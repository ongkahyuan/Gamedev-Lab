using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startButton;
    void Start()
    {
    }

    void Awake()
    {
        Debug.Log("oldStart state at awake: " + playerStates.oldStart);
        if (playerStates.oldStart)
        {
            startButton.SetActive(false);
            Time.timeScale = 1.0f;
        }
        else
        {
            Time.timeScale = 0.0f;
        }
    }

    public void StartButtonClicked()
    {
        Debug.Log("Button Pressed");
        foreach (Transform eachChild in transform)
        {
            Debug.Log(eachChild.name);
            if (eachChild.name == "Start")
            {
                Debug.Log("Child found. Name: " + eachChild.name);
                // disable them
                eachChild.gameObject.SetActive(false);
                Time.timeScale = 1.0f;
                playerStates.oldStart = true;
            }
        }
    }

    public void RestartButtonClicked()
    {
        foreach (Transform eachChild in transform)
        {
            Debug.Log(eachChild.name);
            if (eachChild.name == "Restart")
            {
                Debug.Log("restart found");
                Time.timeScale = 1.0f;
                eachChild.gameObject.SetActive(false);
                UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
