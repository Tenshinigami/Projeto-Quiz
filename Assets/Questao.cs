using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 
public class Questao
{
    public Questao(string pergunta, List<string> respostas, int respostaCerta)
    {
        this.pergunta = pergunta;
        this.respostas = respostas;
        this.respostaCerta = respostaCerta;
    }

    public string pergunta;
    public List<string> respostas;
    public int respostaCerta;

    public bool acertouQuestao(string resposta)
    {
        return respostas[respostaCerta] == resposta;
    }


}
     
