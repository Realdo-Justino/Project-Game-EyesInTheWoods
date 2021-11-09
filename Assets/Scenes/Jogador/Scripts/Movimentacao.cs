using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadePersonagem=15;
    public float forcaPulo=16;

    //Criação de uma variavel que permite aplicação de forças fisicas
    private Rigidbody2D rig;

    public bool pulando;

    //Criação de uma varival que permite saber qual foi o ultimo input horizontal
    public float caraPersonagem;

    //Variavel que permite saber se o botão de iniciar foi prescionado
    public bool inicio;

    public bool paralisado=false;
    public bool paralisado2=false;
    public float contador_stun;
    public Animator anim;

    [SerializeField] DialogUI dialogUI;

    public DialogUI DialogUI =>dialogUI;

    public IInteractable Interactable{get;set;}
    

    void Start()
    {
        //Puxa as fisicas do personagem
        rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(dialogUI.IsOpen) return;
        //Se o botão de inicio foi prescionado, os inputs são registrados
        if((paralisado==false)&&(paralisado2==false)){
            Move();
            Pulo();
        }
        else{
            contador_stun++;
            if(contador_stun>=200){
                paralisado=false;
                contador_stun=0;
            }
        }
        if(Input.GetKeyDown(KeyCode.E)){
            if(Interactable!=null){
                Interactable.Interact(this);
            }
        }
    }

    void Move()
    {
        //Variavel que checa inputs horizontais
        Vector3 movimento= new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        //Cria uma velocidade de moviemnto consistente para todas as maquinas
        if(movimento.x!=0){
            anim.SetBool("Andando",true);
        }
        else{
            anim.SetBool("Andando",false);
        }
        transform.position += movimento*Time.deltaTime*velocidadePersonagem;

        caraPersonagem=Input.GetAxis("Horizontal");
        //Dependendo do input adquirido, rotacione o sprite
        if(caraPersonagem>0){
            transform.eulerAngles=new Vector2(0f,0f);
        }
        if(caraPersonagem<0){
            transform.eulerAngles=new Vector2(0f,180f);
        }
    }
    void Pulo()
    {
        //Se o botão de pulo foi prescionado e a variavel retornada for falsa, adicione uma força vertical em forma de impulso
        if(Input.GetButtonDown("Jump") && !pulando){
            rig.AddForce(new Vector2(0f,forcaPulo), ForceMode2D.Impulse);
        }

    }
}
