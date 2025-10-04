using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplahToMeun : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SplashGo());
    }
    IEnumerator SplashGo()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}
