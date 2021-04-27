using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Popup : MonoBehaviour
{
    private static TextMeshProUGUI mText;
    private static Image img;

    public void Awake() {
        Popup.mText = gameObject.GetComponentInChildren <TextMeshProUGUI> ();
        Popup.img = gameObject.GetComponent<Image>();
    }

    public static void SetPopup(string text)
    {
        Popup.mText.SetText(text);
        Popup.img.enabled = true;
    }

    public static void ClearPopup()
    {
        mText.text = "";
        Popup.img.enabled = false;
    }

}
