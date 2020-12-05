﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{   
    public float gameTime; //타이머, 유니티 안에서 기준시간 선언
    // Start is called before the first frame update
    public Image progressBar;
    private float _time;

    void Start()
    {
        progressBar = this.transform.GetChild(0).gameObject.GetComponent<Image>();
        _time = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameTime > 0)
            gameTime -= Time.deltaTime;

        if(gameTime <= 0)
        {
            Time.timeScale = 0;
        }

        if(progressBar.fillAmount <= 0.25f)
        {
            progressBar.color = new Color(255, 0, 0, 100);
        }

        progressBar.fillAmount = 1.0f * gameTime / _time; 
    }
}