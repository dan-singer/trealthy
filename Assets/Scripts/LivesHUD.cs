﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LivesHUD : MonoBehaviour
{

    public CPlayerVisibility playerVisibility;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Lives: {playerVisibility.lives}";
    }
}