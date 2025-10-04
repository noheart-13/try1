using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmeun : MonoBehaviour
{
    [SerializeField] GameObject START;
    [SerializeField] GameObject Load;
    [SerializeField] GameObject Credits;
    [SerializeField] GameObject END;
    [SerializeField] AudioSource BGM;
    [SerializeField] GameObject FADEOUT;
    [SerializeField] int SceneToLoad;
    [SerializeField] int SaveTansferValue;
    void Start()
    {

    }
    public void StartGame()
    {
        FADEOUT.SetActive(true);
        StartCoroutine(TurnToNight());
    }
    public void LoadGmae()
    {
        SaveTansferValue = PlayerPrefs.GetInt("LoadStart");
        if (SaveTansferValue > 0)
        {
            SceneToLoad = SaveTansferValue + 1;
            FADEOUT.SetActive(true);
            StartCoroutine(LoadScene());
        }
    }
    public void GoToCredits()
    {
        FADEOUT.SetActive(true);
        StartCoroutine(TurnToCredits());
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    void Update()
    {

    }

    IEnumerator TurnToNight()
    {
        BGM.Stop();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneToLoad);
    }
    IEnumerator TurnToCredits()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);

    }
}

