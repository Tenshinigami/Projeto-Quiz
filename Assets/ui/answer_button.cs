using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class answer_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Passo 1: Pegar componente BOT�O 
        // Passo 2: Acessar o ONCLICK dele
        // 'AddListener' -> Adicionar ouvinte -> Quero ouvir quando o clique acontecer -> reagir ao clique
        
        GetComponent<Button>().onClick.AddListener(onButtonClick);
    }

    void onButtonClick() { 
        // Roda quando o bot�o � clicado
    }


    public void colocarRespostaEmBotao(string answer)
    {
        // Pegando componente de um filho dele
        // TextMeshProUGUI -> Text
        // Coloco o parametro da fun��o dentro do text 
        GetComponentInChildren<TextMeshProUGUI>().text = answer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
