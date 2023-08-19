using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question_canvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Questao question = new Questao("Qual é a resposta?", new List<string> { "A", "S", "C", "D" }, 1);
        setarPergunta(question);
    }

    public void setarPergunta(Questao question) {

        answer_buttons_controller buttonsController = GetComponentInChildren<answer_buttons_controller>();

        buttonsController.setarBotoesParaPergunta(question);
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }
}
