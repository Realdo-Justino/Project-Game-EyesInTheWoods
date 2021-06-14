using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao_inimigo_voador : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform player;

    [SerializeField]
    Transform inimigo;

    [SerializeField]
    Padrao_Inimigo_Voador Padrao_Inimigo_Voador;

    [SerializeField]
    bool estado;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaPlayer=Vector2.Distance(inimigo.position,player.position);
        if(transform.position.x<=player.position.x){
            estado=true;
        }
        else{
            estado=false;
        }
        Padrao_Inimigo_Voador.visao_inimigo_voador=estado;
    }
}
