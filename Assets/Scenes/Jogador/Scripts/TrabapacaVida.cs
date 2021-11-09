using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrabapacaVida : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vida_personagem_principal Vida_personagem_principal;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown((KeyCode.V))){
            Vida_personagem_principal.vidaAtual=5;
        }
    }
}
