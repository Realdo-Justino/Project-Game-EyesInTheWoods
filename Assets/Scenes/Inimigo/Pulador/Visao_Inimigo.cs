using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao_Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform player;

    [SerializeField]
    Transform inimigo;
    public inimigo_ataque inimigo_ataque;

    [SerializeField]
    float visao=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaPlayer=Vector2.Distance(inimigo.position,player.position);
        if(distanciaPlayer<=visao){
            inimigo_ataque.estado=1;
        }
        else{
            inimigo_ataque.estado=0;
        }
        if(transform.position.x<player.position.x){
            inimigo_ataque.ladoE=true;
        }
        else{
            inimigo_ataque.ladoE=false;
        }
    }
}
