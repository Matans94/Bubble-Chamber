using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

// attach to UI Text component (with the full text already there)

public class UI_Assistant : MonoBehaviour 
{

    TMP_Text txt;
    string story;

    void Awake () 
    {
        txt = GetComponent<TMP_Text> ();
        story = txt.text;
        txt.text = "";

        
        StartCoroutine ("PlayText");
    }
    

    IEnumerator PlayText(string msgText)
    {
        foreach (char c in story) 
        {
            txt.text += c;
            yield return new WaitForSeconds (0.125f);
        }
        
    }

}