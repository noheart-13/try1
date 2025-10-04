using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject textBox;
    public GameObject Nextbutton;
    public AudioSource BGM;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    public GameObject mainTextObject;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject scence;
    [SerializeField] GameObject choice;
    [SerializeField] GameObject surprise;
    [SerializeField] GameObject curious;
    [SerializeField] GameObject afraid;
    [SerializeField] GameObject fadeout;
    void Update()
    {
        textLength = TextCreater.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }    
    IEnumerator EventStarter()
     {  //event1
        yield return new WaitForSeconds(3); 
        textBox.SetActive(true);
        mainTextObject.SetActive(true);
        textToSpeak = "(内心独白)";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true; 
        scence.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventPos = 1;

    }
    IEnumerator Eventone()
    {
        Nextbutton.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        BGM.Stop();
        eventPos = 2;
        choice.SetActive(true);
    }
    IEnumerator Eventtwo()
    {
        yield return new WaitForSeconds(0.5f);
        choice.SetActive(false);
        yield return new WaitForSeconds(1);

    }
    IEnumerator Eventthree()
    {
        Nextbutton.SetActive(false);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine (Eventone());
        }
        if (eventPos == 2)
        {
            StartCoroutine (Eventtwo());
        }
        if(eventPos == 3)
        {
            StartCoroutine(Eventthree());
        }
    }
    public void Curoius()
    {
        StartCoroutine(CuriousSeq());
    }
    IEnumerator CuriousSeq()
    {
        choice.SetActive(false);
        yield return new WaitForSeconds (0.5f);
        mainTextObject.SetActive(true);
        textToSpeak = "【好奇】 那个方向……是禁林深处？传说竟然是真的？";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        scence.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventPos = 3;

    }
    public void Surprise()
    {
        StartCoroutine(SurpriseSeq());
    }
    IEnumerator SurpriseSeq()
    {
        choice.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        textToSpeak = "【惊讶】 那是什么？流星？怎么会这么大……";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        scence.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventPos = 3;
    }
   public void Afraid()
    {
        StartCoroutine(AfraidSeq());
    }
    IEnumerator AfraidSeq()
    {
        choice.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        textToSpeak = "【不安】 这种感觉……不是兴奋，反而有点让人喘不过气。";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        scence.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventPos = 3;  
    }
   }





