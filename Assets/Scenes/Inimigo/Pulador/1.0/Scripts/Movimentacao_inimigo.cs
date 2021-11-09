using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao_inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    //Declaração da distancia que é feita do groundcheck para frente
    public float distance;

    //Preparando uma variavel pra chamr outra função
    public inimigo_ataque inimigo_ataque;

    //Criação de um "vetor3" que adquiri os valores do objeto
    public Transform groundCheck;

    private void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detecção do objeto, para saber se ele ainda se encontra em contato com o chão
        RaycastHit2D chao=Physics2D.Raycast(groundCheck.position, Vector2.down,distance);
        if(chao.collider==false){
            //Chamada de outra função que faz o inimigo virar 180 graus
            inimigo_ataque.check();
        }
    }
    
}
