using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo_ataque : MonoBehaviour
{
    public float velocidade;

    public int estado;
    
    public bool ladoE;
    public float contador=0;

    public float pulo;
    public Animator anim;

    Rigidbody2D rb;
    public bool isRight=true;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        contador++;
        if(estado==0){
    
            EstadoCalmo();
        }
        if(estado==1){
            lado();
        }
        if((estado==1)&&(contador>1000)){
            EstadoAgressivo();
        }
    }
    public void check(){
        //precisa de polimento
        if(estado==0){
            if(isRight==true){
                transform.eulerAngles= new Vector3(0,0,0);
                isRight=false;
            }else{
                transform.eulerAngles= new Vector3(0,180,0);
                isRight=true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.CompareTag("Player")){
            colisor.gameObject.GetComponent<Vida_personagem_principal>().receberDano(1);
        }
        
    }
    void EstadoCalmo(){
        transform.Translate(Vector2.right*velocidade*Time.deltaTime);
    }
    public void EstadoAgressivo(){
        rb.AddForce(new Vector2(pulo,7f), ForceMode2D.Impulse);
        contador=0;
    }
    void lado(){
        if(ladoE==true){
                pulo=7;
                transform.eulerAngles= new Vector3(0,0,0);
        }else{
                transform.eulerAngles= new Vector3(0,180,0);
                pulo=-7;
        }
    }
    void OnCollisionEnter2D(Collision2D colisor) 
    {
        //Quando o jogador estiver colindindo com uma plataforma, ele pode pular
        if(colisor.gameObject.layer==8){
            //Função que avisa se o input de pulo é valido
            anim.SetBool("Pulando",false);
        }
    }
    void OnCollisionExit2D(Collision2D colisor) 
    {
        //Quando o jogador não estiver em contato com uma plataforma, ele não pode pular 
        if(colisor.gameObject.layer==8){
            //Função que avisa se o input de pulo é valido
            anim.SetBool("Pulando",true);
        }
    }
}
