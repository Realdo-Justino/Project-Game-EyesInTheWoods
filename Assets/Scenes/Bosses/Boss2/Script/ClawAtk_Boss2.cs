using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawAtk_Boss2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public bool doOnce;
    [SerializeField] public bool doOnce2;
    [SerializeField] Transform player;

    [SerializeField] public bool LadoE;

    [SerializeField] public float posicaoPlayer;

    [SerializeField] public float Distancia;

    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] DownwordAtk DownwordAtk;
    [SerializeField]Animations Animations;
    
    void Start()
    {
        DoOnce();
    }

    // Update is called once per frame
    void Update()
    {
        DoOnce();
        if(posicaoPlayer!=0){
            if((transform.position.x>posicaoPlayer-3)&&(transform.position.x<posicaoPlayer+3)){
                Animations.Clawing=true;
                Animations.Walking=false;
                DoOnce2();
            }
            else{
                Animations.Walking=true;
                transform.Translate(Vector2.right*20*Time.deltaTime);
            }
        }
    }
    public void DoOnce(){
        if(player!=null){
            if(doOnce==true){
                posicaoPlayer=player.position.x;
                doOnce = false;
                Lado();
            }
        }
    }

    public void Lado(){
        if(player!=null){
            if(transform.position.x<player.position.x){
                LadoE=true;
            }
            else{
                LadoE=false;
            }
            switch(LadoE){
                case true:
                    transform.eulerAngles= new Vector3(0,0,0);
                    Distancia=4;
                    break;
                case false:
                    transform.eulerAngles= new Vector3(0,180,0);
                    Distancia=-4;
                    break;
            }
        }
    }
    public void DoOnce2(){
        if(doOnce2==true){
            rigidBody.AddForce(new Vector2(Distancia,40f), ForceMode2D.Impulse);
            doOnce2=false;
            RandomNumber();
        }
    }
    public void RandomNumber(){
        if(this.enabled==true){
            var numero= Random.Range(0.0f, 9.0f);
            if(numero>2){
                
            }
            else{
                Animations.ClawingJump=true;
                DownwordAtk.Topo=true;
                DownwordAtk.enabled=true;
                DownwordAtk.Repeat();
            }
        }
    }
    
}
