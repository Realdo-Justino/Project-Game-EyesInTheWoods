using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padrao_Inimigo_Voador : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public bool visao_inimigo_voador;

    [SerializeField]
    Movimentacao_Inimigo_Voador Movimentacao_Inimigo_Voador;

    [SerializeField]
    Ataque_Inimigo_Voador Ataque_Inimigo_Voador;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EstadoAtaque();
    }

    void EstadoAtaque(){
        Ataque_Inimigo_Voador.enabled = true;
    }
    void EstadoCalmo(){
        Movimentacao_Inimigo_Voador.enabled=true;
    }
    void lado(){
        if(visao_inimigo_voador==true){
            transform.eulerAngles=new Vector2(0f,180f);
        }
        else{
            transform.eulerAngles=new Vector2(0f,0f);
        }
    }
}
