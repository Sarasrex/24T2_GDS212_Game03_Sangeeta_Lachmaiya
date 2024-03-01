using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    public GameObject LosePanel;
    public GameObject WinPanel;
    public GameObject Player;


    private void Start()
    {
        if (LosePanel != null) LosePanel.SetActive(false);
        if (WinPanel != null) WinPanel.SetActive(false);
    }

    public void Update()
    {
        if (Player.transform.position.y <= -10f)
        {
            if (LosePanel != null) LosePanel.SetActive(true);
            Debug.Log("Player fell off");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WinPanel.SetActive(true);
            Debug.Log("Player hit end");
            Player.GetComponent<playerMovement>().enabled = false;
            Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }



    public void MainMenu()

    {
        SceneManager.LoadSceneAsync(0);
    }


    public void Play()
    
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Lvl1()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Lvl2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Lvl3()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Lvl4()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void Lvl5()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void Lvl6()
    {
        SceneManager.LoadSceneAsync(6);
    }

}