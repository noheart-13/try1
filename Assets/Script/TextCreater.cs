
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class TextCreater : MonoBehaviour
{
    public static TMP_Text viewText;
    public static bool runTextPrint;
    public static int charCount;
    [SerializeField] string transferText;
    [SerializeField] int interCount;


    void Update()
    {
        interCount = charCount;
        charCount = GetComponent<TMPro.TMP_Text>().text.Length;
        if (runTextPrint == true)
        {
            runTextPrint = false;
            viewText =GetComponent<TMPro.TMP_Text>();
            transferText=viewText.text;
            viewText.text = "";
            StartCoroutine(RollText());
        }    
    } 
    IEnumerator RollText()
    {
       foreach (char c in transferText)
        {
            viewText.text += c;
            yield return new WaitForSeconds(0.03f);
        }







    }
}   
    
