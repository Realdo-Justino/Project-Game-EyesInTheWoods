using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padrao_boss2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool jump;
    [SerializeField] ClawAtk_Boss2 ClawAtk_Boss2;
    [SerializeField] JumpAtk_Boss2 JumpAtk_Boss2;
    [SerializeField]Downword_Chosing Downword_Chosing;
    [SerializeField]Animations Animations;
    [SerializeField] bool DoneOne;

    [SerializeField] public bool Stop;
    void Start()
    {
        GenerateAtk();
    }

    // Update is called once per frame
    void Update()
    {   
        if(this.enabled==true){
        Downword_Chosing.enabled =false;
        }
    }
    public void GenerateAtk(){
        
        if(Stop==false){
            var numero= Random.Range(0.0f, 9.0f);
            Debug.Log(numero);
            if(numero>5){
                jump=true;
            }
            else{
                jump=false;
            }
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {
        CodeAcctivator();
        yield return new WaitForSeconds(3);
        DeactivationsCall();
        GenerateAtk();
        
    }
    public void CodeAcctivator(){
        switch(jump){
            case true: JumpCall();
            break;
            case false: ClawCall();
            break;
        }
    } 
    private void ClawCall(){
        ClawAtk_Boss2.doOnce=true;
        ClawAtk_Boss2.doOnce2=true;
        ClawAtk_Boss2.posicaoPlayer=0;
        ClawAtk_Boss2.enabled=true;
    }
    private void JumpCall(){
        Animations.Jumping=true;
        JumpAtk_Boss2.enabled=true;
        JumpAtk_Boss2.DoOnce=true;
    }
    private void DeactivationsCall(){
        Animations.Jumping=false;
        Animations.Clawing=false;
        JumpAtk_Boss2.enabled=false;
        ClawAtk_Boss2.enabled=false;
    }
}
