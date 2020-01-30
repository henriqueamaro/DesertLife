using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0;

    private Vector3 PosicaoInicial;

    private float TamanhoRealImagem;

    private void Awake()
    {
        PosicaoInicial = transform.localPosition;

        float TamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        TamanhoRealImagem = TamanhoDaImagem * escala;
        Debug.Log(TamanhoRealImagem);


    }

    void Update()
    {
        float Deslocamento = Mathf.Repeat(Time.time * velocidade, TamanhoRealImagem);
        transform.position = PosicaoInicial + Vector3.left * Deslocamento;
    }
}
