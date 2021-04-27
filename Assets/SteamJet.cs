using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamJet : MonoBehaviour
{
    [SerializeField]
    private GameObject jet;
    private bool jetActive;

    [SerializeField]
    private float rate = 1;
    [SerializeField]
    private float dmg;

    [SerializeField]
    private float dmgDelay = 1;

    private GameObject enemy = null;

    private void Awake()
    {
        jet.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        jetActive = false;
        InvokeRepeating("FlipJet", 0, rate);
    }

    void FlipJet()
    {
        jetActive = !jetActive;
        jet.SetActive(jetActive);
        if(jetActive == false) {
            CancelInvoke("DealDmg");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            enemy = collision.gameObject;
            InvokeRepeating("DealDmg", 0, dmgDelay);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enemy = null;
            CancelInvoke("DealDmg");
        }
    }


    void DealDmg()
    {
        if (enemy != null)
        {
            Debug.Log("kanw zhmia");
        }
    }
}
