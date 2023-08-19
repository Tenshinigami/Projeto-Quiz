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

        // Explica��o [AddRange]
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

    // Chamo essa fun��o quando recebo uma nova pergunta, 
    // E quero atualizar os bot�es
    public void setarBotoesParaPergunta(Questao question)
    {

        // Se a lista de bot�es estiver vazia, bot�es ainda n�o foram encontrados
        // Ent�o, eu chamo carregarBot�es
        if (buttons.Count == 0) {
            carregarBotoes();
        }

        // Iterando nos bot�es, colocando cada resposta que estiver dispon�vel no indice equivalente
        // Primeiro bot�o -> Primeira resposta
        // Segundo bot�o -> Segunda resposta

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
