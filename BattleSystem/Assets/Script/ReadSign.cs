﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadSign : MonoBehaviour
{
    public string Text;
    private Rigidbody2D SignBody;
    public GameObject SignText;
    //add gameobject dialogue box when the ui sprites are added
    
    void Start()
    {
        SignBody = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        SignText.SetActive(true);
    }
    void OnTriggerExit2D(Collider2D col)
    {
        SignText.SetActive(false);
    }
}
