using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Scene2ChoiceLoader : MonoBehaviour 
{
    public GameObject charCunZhang;
    public GameObject charVellege;
    public GameObject charMan;
    public GameObject textBox;
    public GameObject Nextbutton;
    [SerializeField] GameObject fadein;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject Fadeout;
    [SerializeField] GameObject END;
    public GameObject mainTextObject;
    public AudioSource BGM;
    [SerializeField] int eventpos= 0;
    [SerializeField] GameObject charVellegerNameA;
    [SerializeField] GameObject charVellegerNameB;
    [SerializeField] GameObject VellegerMangername;
    [SerializeField] GameObject ManName;
    [SerializeField] GameObject Alice;
    [SerializeField] GameObject hunter;
    [SerializeField] GameObject studyer;
    [SerializeField] GameObject choice2;
    [SerializeField] GameObject speed;
    [SerializeField] GameObject knowledge;
    [SerializeField] GameObject strength;
    [SerializeField] GameObject AliceName;
    [SerializeField] GameObject HunterName;
    [SerializeField] GameObject choice3;
    [SerializeField] GameObject Answer1;
    [SerializeField] GameObject Answer2;
    [SerializeField] GameObject Answer3;
    [SerializeField] GameObject choice4;
    [SerializeField] GameObject Answer4;
    [SerializeField] GameObject Answer5;
    [SerializeField] GameObject Answer6;
    [SerializeField] GameObject Sorry;
    void Start()
    {
        StartCoroutine(EventStarter());
        Fadeout.SetActive(false);
        END.SetActive(false);
        PlayerPrefs.SetInt("LoadStart",2);
    }
    void Update()
    {
        textLength = TextCreater.charCount;
    }
    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(3);
        fadein.SetActive(false);
        charCunZhang.SetActive(true);
        textBox.SetActive(true);
        ManName.SetActive(false);
        mainTextObject.SetActive(true);
        charVellegerNameA.SetActive(false);
        charVellegerNameB.SetActive(false);
        textToSpeak = "（拄着拐杖，神色微妙）大家都看到了昨晚的异象。根据古老的训诫，那是灾厄之星，会带来不详。任何人不得靠近禁林！";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;      
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventpos= 1;
    }
    IEnumerator EventOne()
    {
        VellegerMangername.SetActive(false);
        charVellege.SetActive(true);
        charVellegerNameA.SetActive(true);
        textToSpeak = "可是村长，万一是什么宝物呢？";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        eventpos = 2;
    }
    IEnumerator EventTwo()
    {
        charVellegerNameA.SetActive(false);
        charVellegerNameB.SetActive(true);
        textToSpeak = "你没感觉到吗？那光让人心里发毛！肯定是诅咒！";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        eventpos = 3;

    }
    IEnumerator EventThree()
    {
        charCunZhang.SetActive(false);
        charVellege.SetActive(false);
        charVellegerNameA.SetActive(false);
        charVellegerNameB.SetActive(false);
        charMan.SetActive(true);
        VellegerMangername.SetActive(false);
        ManName.SetActive(true);
        textToSpeak = "（内心独白）灾厄……宝物……无论是什么，它改变了什么。我必须去看看。";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        eventpos = 4;
    } 
    IEnumerator EventFour()
    {
        choice2.SetActive(true);
        Nextbutton.SetActive(false);
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        eventpos = 5;
    }
    IEnumerator EventEight()
    {
        ManName.SetActive(false);
        hunter.SetActive(true);
        HunterName.SetActive(true);
        textToSpeak = "(Pausing, not looking at you, voice low) ...death, and rebirth. The aura of contradiction. (He finally glances at you) You do not belong here, why risk yourself?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventpos = 9;
    }
    IEnumerator EventNine()
    {
        ManName.SetActive(true);
        HunterName.SetActive(false);
        textToSpeak = "Because the answer is there.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventpos = 10;
    }
    IEnumerator EventTen()
    {
        ManName.SetActive(false);
        HunterName.SetActive(true);
        textToSpeak = "(After a moment of silence) Keep up if you can, then follow. But don't expect me to save you.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        choice4.SetActive(true);
        Nextbutton.SetActive(false);
    }
    IEnumerator EventSixA1()
    {
        choice2.SetActive(false);
        AliceName.SetActive(false);
        ManName.SetActive(true);
        textToSpeak = "Alice? Do you mean to...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventpos = 7;
    }
    IEnumerator EventSixA2()
    {
        choice2.SetActive(false);
        AliceName.SetActive(true);
        ManName.SetActive(false);
        textToSpeak = "(Leaning in, lowering my voice) I know a little path that can bypass the guards. So, adventurer, do you dare to come with me to see the truth for yourself? As usual, I’ll clear the way, and you… hmm, keep watch for me?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        choice3.SetActive(true);
        Nextbutton.SetActive(false);
    }
   
    public void NextButton()
    {
        if (eventpos==1)
        {
            StartCoroutine(EventOne());
        }
        if (eventpos == 2)
        {
            StartCoroutine (EventTwo());
        }
        if(eventpos == 3)
        {
            StartCoroutine(EventThree());
        }
        if (eventpos == 4)
        {
            StartCoroutine(EventFour());
        }
        if (eventpos == 6)
        {
            StartCoroutine(EventSixA1());
        }
        if (eventpos == 7) 
            {
            StartCoroutine(EventSixA2());
        }
        if (eventpos == 8)
        {
            StartCoroutine(EventEight());
        }
        if (eventpos == 9)
        {
            StartCoroutine(EventNine());
        }
        if (eventpos == 10)
        {
            StartCoroutine(EventTen());
        }
    }
    public void Speed()
    {
       StartCoroutine(speedSep());
    }
    IEnumerator speedSep()
    {
        choice2.SetActive(false);
        ManName.SetActive(false);
        Alice.SetActive(true);
        AliceName.SetActive(true);
        textToSpeak = "(Brushing the dust off his hands, he gives you a confident smile) Hey, you're interested in that star too, right? Don't listen to the old men scaremongering.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Nextbutton.SetActive(true);
        eventpos = 6;
    }
    IEnumerator strengthSeq()
    {
        choice2.SetActive(false);
        Nextbutton.SetActive(true);
        textToSpeak = "(Noticing his gaze) You felt it too, didn't you? The... change in that forest.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreater.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        eventpos = 8;
    }
    public void Answer()
    {
        StartCoroutine(speedSepAnswer());
    }
    IEnumerator speedSepAnswer()
    {
        choice3.SetActive(false);
        AliceName.SetActive(false);
        yield return new WaitForSeconds(3);
        Fadeout.SetActive(true);
        BGM.Stop();
        END.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
    public void ANAWER()
    {
        StartCoroutine(strengthSeqAnswer());
    }
    public void Strength()
    {
        StartCoroutine(strengthSeq());
    }
    IEnumerator strengthSeqAnswer()
    {
        choice4.SetActive(false);
        HunterName.SetActive(false);
        yield return new WaitForSeconds(3);
        Fadeout.SetActive(true);
        BGM.Stop();
        END.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
    public void Secret()
    {
        StartCoroutine(SecretSeq());
    }
    IEnumerator SecretSeq()
    {
        yield return new WaitForSeconds(3);
        Fadeout.SetActive(true);
        BGM.Stop();
        END.SetActive(true);
        Sorry.SetActive(true );
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}


    
