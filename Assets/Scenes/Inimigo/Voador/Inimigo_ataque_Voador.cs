using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_ataque_Voador : MonoBehaviour
{
    public float velocidade;

    public int estado;
    
    public bool ladoE;
    public float contador=0;

    public float contador2=0;

    public float pulo;

    public float posicaoM=0;
    public float posicaom=0;
    public bool certo2=true;
    public bool teste=true;
    public bool certo=true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        contador++;
        if(estado==0){
            EstadoCalmo();
        }
        if((estado==1)&&(contador>200)){
            EstadoAgressivo();
        }
        if(contador2>0){
            EstadoRetorno();
        }
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.CompareTag("Player")){
            colisor.gameObject.GetComponent<Vida_personagem_principal>().receberDano(1);
        }
        
    }
    void EstadoCalmo(){
        transform.Translate(Vector2.right*velocidade*Time.deltaTime);
        if(certo==true){
            posicaoM=transform.position.x+10;
            posicaom=transform.position.x-10;
            certo=false;
        }
        if((transform.position.x<posicaoM)&&(teste==true)){
            transform.eulerAngles= new Vector3(0,180,0);
        }
        if((transform.position.x>posicaom)&&(teste==false)){
            transform.eulerAngles= new Vector3(0,0,0);
        }
        if(transform.position.x>=posicaoM){
            teste=false;
        }
        if(transform.position.x<=posicaom){
            teste=true;
        }
        

        
    }
    public void EstadoAgressivo(){
        //Precisa de polimentos
        if(ladoE==true){
                transform.eulerAngles= new Vector3(0,180,0);
                pulo=-1;
        }else{
                transform.eulerAngles= new Vector3(0,0,0);
                pulo=-1;
        }
        if(certo2==true){
            posicaoM=(transform.position.y-2)/4;
            certo2=false;
        }
        Vector3 movimento= new Vector3(pulo,-1f,0f);
        if(transform.position.y>posicaoM){
            transform.Translate(movimento*Time.deltaTime*10f);
        }else{
            contador=0;
            contador2=1;
        }

    }
    public void EstadoRetorno(){
        contador=0;
        //trocar depois
        if(certo2==false){
            posicaoM=(posicaoM*4)+2;
            certo2=true;
        }
        Vector3 movimento2= new Vector3(pulo,1f,0f);
        if(transform.position.y<posicaoM){
            transform.Translate(movimento2*Time.deltaTime*10f);
        }else{
            certo2=true;
            contador=0;
            contador2=0;
        }
    }
}