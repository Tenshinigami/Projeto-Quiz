using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answer_buttons_controller : MonoBehaviour
{
    List<answer_button> buttons = new List<answer_button>{ };
    // Start is called before the first frame update
    void Start()
    {


    
    }

    void carregarBotoes()
    {
        // GetComponents -> lista de componentes // InChildren -> Em todos os filhos

        // Explicação [AddRange]
        // AddRange -> 
        // Lista a: []
        // Lista b: [1,2,3]
        // a.AddRange(b);
        // a == [1,2,3]
        // Lista a: [4]
        // Lista b: [1,2,3]
        // a.AddRange(b);
        // a == [1,2,3,4]

        buttons.AddRange(GetComponentsInChildren<answer_button>());

    }

    // Chamo essa função quando recebo uma nova pergunta, 
    // E quero atualizar os botões
    public void setarBotoesParaPergunta(Questao question)
    {

        // Se a lista de botões estiver vazia, botões ainda não foram encontrados
        // Então, eu chamo carregarBotões
        if (buttons.Count == 0) {
            carregarBotoes();
        }

        // Iterando nos botões, colocando cada resposta que estiver disponível no indice equivalente
        // Primeiro botão -> Primeira resposta
        // Segundo botão -> Segunda resposta

        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].colocarRespostaEmBotao(question.respostas[i]);
        }
    }

    // Update is called once per frame
    void Update() 
    {
        
    }
}
