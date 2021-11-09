using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1_padrao1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool visao_boss;

    public bool charging=false;
    public bool charging_hitbox;

    [SerializeField]
    public float contador=0;

    [SerializeField]
    Charge_boss1 Charge_boss1;

    [SerializeField]
    Fogo_boss1 Fogo_boss1;

    [SerializeField]
    Grito_boss1 Grito_boss1;

    [SerializeField]
    Idle_hitbox_boss1 Idle_hitbox_boss1;

    [SerializeField]
    Charge_hitbox_boss1 Charge_hitbox_boss1;

    [SerializeField]
    public bool fireing=false;

    [SerializeField]
    public bool screaming=false;

    public Animator anim;

    void Start()
    {
        charging_hitbox=true;
    }

    // Update is called once per frame
    void Update()
    {
        EstadoInicial();
    }
    public void EstadoInicial(){
        if(contador<=2){
            contador+=Time.deltaTime;
        }
        else if(charging==false){
            InicioLuta();
            anim.SetBool("Andando",true);
            Idle_hitbox_boss1.charge=true;
            Charge_hitbox_boss1.enabled=true;
        
        }
        else if(fireing==false){
            Fogo_boss();
            Charge_boss1.enabled=false;
            anim.SetBool("Andando",false);
            anim.SetBool("Fogo",true);
        }else if(screaming==false){
            Grito_boss1.Grito();
            screaming=true;
            Fogo_boss1.enabled=false;
            anim.SetBool("Fogo",false);
            anim.SetBool("Gritando",true);
        }
        else{
            Grito_boss1.enabled=false;
            charging=false;
            fireing=false;
            screaming=false;
            contador=0;
            anim.SetBool("Gritando",false);
        }
        Hitboxes();
    }

    public void Hitboxes(){
        if(charging_hitbox==false){
            Idle_hitbox_boss1.charge=false;
            Charge_hitbox_boss1.enabled=false;
        }
    }
    public void InicioLuta(){
        Charge_boss1.enabled=true;
        Charge_boss1.charge=true;
    }

    public void Fogo_boss(){
        Fogo_boss1.enabled=true;
        Charge_boss1.FazerUmaVez=false;
        Fogo_boss1.fogo=true;

    }

    public void Grito_boss(){
        Grito_boss1.enabled=true;
        Grito_boss1.fazer_uma_vez=true;
        screaming=true;
    }
    public void lado(){
        if(visao_boss==true){
            transform.eulerAngles=new Vector2(0f,0f);
        }
        else{
            transform.eulerAngles=new Vector2(0f,180f);
        }
    }
}
