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
    //private Rigidbody2D rig;
    //public float conta;
    //public float movimento;

    void Start()
    {
        player = gameObject.GetComponent<Movimentacao>();
        vidaAtual=vidaMaxima;
        contador=Time.deltaTime;
        //rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Saber_vida();
        contador++;
        //movimento=Input.GetAxis("Horizontal");
    }
    //Criação de frames de invencibilidade do personagem
    public void receberDano(int dano){
        if(contador>300){
            vidaAtual-=dano;
            //ricochete();
            contador=0;
        }
    }
    //public void ricochete(){
        //if(movimento>0){
            //conta=5*-1;
       //}
        //if(movimento<0){
            //conta=5;
        //}
        //rig.AddForce(new Vector2(conta,9f), ForceMode2D.Impulse);
    //}
    void Saber_vida(){
        if(vidaAtual<=0){
            Debug.Log("GAME OVER");
            Destroy(GameObject.FindWithTag("Player"));
            Game_Over.Setup();
        }
    }
}
