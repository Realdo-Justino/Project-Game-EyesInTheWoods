using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_personagem_principal : MonoBehaviour
{
    // Start is called before the first frame update
    public int vidaMaxima=5;
    public int vidaAtual;
    Movimentacao player;
    public Game_Over Game_Over;
    public Titulo Titulo;
    public float contador=0;

    [SerializeField]
    Barra_de_Vida Barra_de_Vida;
    public Rigidbody2D rig;
    //public float conta;
    public float lado;
    public bool Cheat;
    FlikerPlayer FlikerPlayer;

    void Start()
    {
        player = gameObject.GetComponent<Movimentacao>();
        FlikerPlayer=GetComponent<FlikerPlayer>();
        vidaAtual=vidaMaxima;
        contador=Time.deltaTime;
        Cheat = true;
        //rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Barra_de_Vida.vida=vidaAtual;
        Saber_vida();
        contador++;
        //movimento=Input.GetAxis("Horizontal");
    }
    //Criação de frames de invencibilidade do personagem
    public void receberDano(int dano){
        if((contador>300)&&(Cheat)){
            vidaAtual-=dano;
            FlikerPlayer.i=true;
            ricochete();
            contador=0;
        }
    }
    public void ricochete(){
        //if(movimento>0){
            //conta=5*-1;
       //}
        //if(movimento<0){
            //conta=5;
        //}
        switch(transform.rotation.y){
            case 0: rig.AddForce(new Vector2(-16f,8f), ForceMode2D.Impulse);
            break;
            case -1: rig.AddForce(new Vector2(16f,8f), ForceMode2D.Impulse);
            break;
            default: Debug.Log("Ocorreu um erro");
            break;
        }
    }
    void Saber_vida(){
        if(vidaAtual<=0){
            Debug.Log("GAME OVER");
            Destroy(GameObject.FindWithTag("Player"));
            Game_Over.Setup();
        }
    }
    void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.tag=="Rock"){
            receberDano(1);
        }
    }
}
