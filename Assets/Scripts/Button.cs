﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool isPushed;
    // Start is called before the first frame update
    void Start()
    {
        isPushed = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("key"))
        {
            isPushed = true;
        }
    }
}
