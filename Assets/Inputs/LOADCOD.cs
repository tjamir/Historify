﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOADCOD : MonoBehaviour
{
    [SerializeField]
    private GameObject logoImg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnClick(string s)
    {
        StartCoroutine(LoadGameProg(s));
    }
    IEnumerator LoadGameProg(string val)
    {
        AsyncOperation Async= SceneManager.LoadSceneAsync(val);

        while (!Async.isDone)
        {
            if(logoImg != null)
            {
                logoImg.SetActive(true);
            }
            yield return null;
        }
    }
}
