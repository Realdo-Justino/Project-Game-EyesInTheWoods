using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Progreamação pra saber se o personagem esta pulando
public class Grounded : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    HitboxJump HitboxJump;

    [SerializeField]
    HitboxJump2 HitboxJump2;

    [SerializeField]
    HitboxIdle HitboxIdle;

    Movimentacao player;
    public Animator pulo;
    void Start()
    {
        //Adiquiri o valor do objeto do jogador
        player = gameObject.transform.parent.gameObject.GetComponent<Movimentacao>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D colisor) 
    {
        //Quando o jogador estiver colindindo com uma plataforma, ele pode pular
        if(colisor.gameObject.layer==8){
            //Função que avisa se o input de pulo é valido
            player.pulando=false;
            HitboxJump.Jump=false;
            HitboxJump2.Jump=false;
            HitboxIdle.Jump=false;
            pulo.SetBool("Pulando",false);
        }
    }
    void OnCollisionExit2D(Collision2D colisor) 
    {
        //Quando o jogador não estiver em contato com uma plataforma, ele não pode pular 
        if(colisor.gameObject.layer==8){
            //Função que avisa se o input de pulo é valido
            player.pulando=true;
            HitboxJump.Jump=true;
            HitboxJump2.Jump=true;
            HitboxIdle.Jump=true;
            pulo.SetBool("Pulando",true);
        }
    }
}
