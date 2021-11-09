using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
    //Criação do local de spawn das balas em relação ao personagem
    public Transform Firepoint;
    [SerializeField]Recarregar Recarregar;
    [SerializeField]Image Image;

    public bool inicio=false;

    //Referencia aos scripts da programação da bala
    public bala Projetil;

    public int municao=6;

    //Chamada o objeto que atua como a bala
    public GameObject bulletPrefab;
    public Animator anim;
    [SerializeField] DialogUI dialogUI;

    public DialogUI DialogUI =>dialogUI;

    public bool paralisado=true;
    public bool waitFReload=false;
    public bool WActivated=false;


    // Update is called once per frame
    void Start(){
        Image.enabled = false;
    }
    void Update()
    {
        if(WActivated){
            if(dialogUI.IsOpen) return;
            //Se o jogo tiver iniciado, o personagem ter munição e houve um input de tiro, realize a progrmação de tiro
            if((Input.GetButtonDown("Fire1"))&&(municao>0)&&(paralisado==true)){
                atirar();
                StartCoroutine(ExampleCoroutine());
        
            }
            //Sistema de recarga da munição
            if(Input.GetButtonDown("Fire3")&&(waitFReload==false)){
                StartCoroutine(Reload());
            }
        }
    }
    void atirar(){
        municao-=1;
        anim.SetBool("Atirando",true);
        //Inicia trajetoria da bala em relação ao personagem principal
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("Atirando",false);
    }
    IEnumerator Reload()
    {
        waitFReload=true;
        float tempo=6-municao;
        municao=0;
        float valor=1f/tempo;
        Image.enabled=true;
        Recarregar.Incremento=valor;
        yield return new WaitForSeconds(tempo);
        Image.enabled=false;
        Recarregar.Incremento=0f;
        Recarregar.CurrentValue=0f;
        municao=6;
        waitFReload=false;
    }

}
