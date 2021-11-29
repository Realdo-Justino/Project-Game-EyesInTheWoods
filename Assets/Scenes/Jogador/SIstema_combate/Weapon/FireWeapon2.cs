using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireWeapon2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int municao=1;
    Animator anim;
    Image Image;
    public bool waitFReload=false;
    [SerializeField]GameObject bulletPrefab;
    Transform Firepoint;
    Recarregar Recarregar;
    void Start()
    {
        anim=GetComponent<Animator>();
        Image=GameObject.Find("Fill").GetComponent<Image>();
        Recarregar=GameObject.Find("Slider").GetComponent<Recarregar>();
        Firepoint=transform.Find("/Jogador/Firepoint");
        municao=1;
    }

    // Update is called once per frame
    public void Reload(){
        StartCoroutine(Reloading());
    }
    public void Fire(){
        StartCoroutine(ExampleCoroutine());
        municao=0;
        anim.SetBool("AtirandoE",true);
        //Inicia trajetoria da bala em relação ao personagem principal
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("AtirandoE",false);
    }
    IEnumerator Reloading()
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
        municao=1;
        waitFReload=false;
    }
}
