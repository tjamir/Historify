﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadcod : MonoBehaviour
{
    [SerializeField]
    private GameObject logoimg;
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
        AsyncOperation async = SceneManager.LoadSceneAsync(val);
        while (!async.isDone)
        {
            if (logoimg != null)
            {
                logoimg.SetActive(true);
            }
            yield return null;
        }
    }
}
