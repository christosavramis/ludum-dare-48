using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopupText : MonoBehaviour
{
    [SerializeField]
    private string text;
    private bool once;

    [Header("Events that run when it enters the collider")]
    [Space]

    public UnityEvent OnEnterEvent;
    public void Awake()
    {
        once = false;
        if (OnEnterEvent == null)
            OnEnterEvent = new UnityEvent();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player") {
            Popup.SetPopup(text);
            if (!once)
            {
                once = true;
                OnEnterEvent.Invoke();

            }
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Popup.ClearPopup();
        }
    }
}
