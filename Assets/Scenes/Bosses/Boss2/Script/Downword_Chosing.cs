using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Downword_Chosing : MonoBehaviour
{
    [SerializeField] public float posicaoPlayer;
    [SerializeField] Transform player;
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] public bool doOnce=true;
    [SerializeField] public bool LadoE;
    [SerializeField] Box Box;
    [SerializeField] public bool stop;
    [SerializeField] Reset_Pattern Reset_Pattern;
    [SerializeField] ClawAtk_Boss2 ClawAtk_Boss2;
    [SerializeField] JumpAtk_Boss2 JumpAtk_Boss2;
    [SerializeField] DownwordAtk DownwordAtk;
    [SerializeField]Padrao_boss2 Padrao_boss2;
    [SerializeField]Vida_boss2 Vida_boss2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void RandomNumber(){
        if(this.enabled==true){
            var numero= Random.Range(0.0f, 9.0f);
            StartCoroutine(ExampleCoroutine(numero));
        }
    }
    IEnumerator ExampleCoroutine(float time)
    {
        Debug.Log(time);
        yield return new WaitForSeconds(time);
        stop=false;
        doOnce=false;
        yield return new WaitForSeconds(1);
        Box.restart=true;
        rigidBody.AddForce(new Vector2(0,-100f), ForceMode2D.Impulse);
        yield return new WaitForSeconds(1);
        Reset();
    }
    public void DoOnce(){
        if(player!=null){
            if(doOnce==true){
                posicaoPlayer=player.position.x;
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
                    break;
                case false:
                    transform.eulerAngles= new Vector3(0,180,0);
                    break;
            }
        }
    }
    public void Move(){
        DoOnce();
        if((posicaoPlayer!=0)&&(stop==true)){
            if((transform.position.x>posicaoPlayer-1)&&(transform.position.x<posicaoPlayer+1)){
            }
            else{
                transform.Translate(Vector2.right*20*Time.deltaTime);
            }
        }
    }
    public void Reset(){
        ClawAtk_Boss2.enabled = false;
        JumpAtk_Boss2.enabled = false;
        Box.enabled = false;
        DownwordAtk.enabled = false;
        Padrao_boss2.enabled = false;
        stop=true;
        Vida_boss2.enabled = true;
        Vida_boss2.Vuneravel();
        }
    public void Starting(){
        Padrao_boss2.Stop=false;
        Padrao_boss2.enabled = true;
        Padrao_boss2.GenerateAtk();
        ClawAtk_Boss2.doOnce=true;
        ClawAtk_Boss2.doOnce2=true;
        ClawAtk_Boss2.posicaoPlayer=0;
        DownwordAtk.Topo=true;
        Padrao_boss2.enabled = true;
        Padrao_boss2.GenerateAtk();
    }
}
