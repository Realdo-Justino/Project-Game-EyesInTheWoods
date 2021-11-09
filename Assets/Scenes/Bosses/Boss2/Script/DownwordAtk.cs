using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownwordAtk : MonoBehaviour
{
    // Start is called before the first frame updat
    [SerializeField] Collider2D colliderBox;
    [SerializeField] ClawAtk_Boss2 ClawAtk_Boss2;
    [SerializeField] Padrao_boss2 Padrao_boss2;
    [SerializeField] JumpAtk_Boss2 JumpAtk_Boss2;
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] Box Box;
    [SerializeField] public bool Topo;
    [SerializeField] Downword_Chosing Downword_Chosing;
    [SerializeField] Collider2D Pe;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ClawAtk_Boss2.enabled = false;
        Padrao_boss2.Stop=true;
        Padrao_boss2.enabled = false;
        JumpAtk_Boss2.enabled = false;
    }
    public void OnTriggerExit2D(Collider2D collider) {
        if(this.enabled==true){
        Debug.Log(collider.tag);
        //if(collider.tag=="Top"){
            //StartCoroutine(ExampleCoroutine(1));
        //}
            if(collider.tag=="Acctivate"){
                ActivateBox();
            }
        }
    }
    public void ActivateBox(){
        Topo=false;
        Box.enabled = true;
        Box.restart=false;
        Downword_Chosing.posicaoPlayer=0;
        Downword_Chosing.doOnce = true;
        Downword_Chosing.enabled = true;
        Downword_Chosing.RandomNumber();
        this.enabled = false;
        
    }
    IEnumerator ExampleCoroutine(int tempo)
    {
        yield return new WaitForSeconds(tempo);
        Topo=false;
        ActivateBox();
    }
    IEnumerator Coroutine2()
    {
        yield return new WaitForSeconds(1);
        rigidBody.AddForce(new Vector2(1,180f), ForceMode2D.Impulse);
    }
    public void Repeat(){
        if(Topo==true){
            Pe.enabled= false;
            rigidBody.AddForce(new Vector2(1,180f), ForceMode2D.Impulse);
            StartCoroutine(FeetReturn());
        }
    }
    IEnumerator FeetReturn(){
        yield return new WaitForSeconds(0.2f);
        Pe.enabled= true;
    }
}
