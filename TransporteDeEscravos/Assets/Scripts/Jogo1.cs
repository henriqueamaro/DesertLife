﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jogo1 : MonoBehaviour
{

    public void CarregaIntroducao()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    public void CarregarFase1()
    {
        SceneManager.LoadScene("Fase1");
    }


    public void EncerrarJogo()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
