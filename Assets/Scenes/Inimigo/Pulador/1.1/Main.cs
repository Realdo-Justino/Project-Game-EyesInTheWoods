using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GroundCheck GroundCheck;
    [SerializeField] MoveEnemy MoveEnemy;
    [SerializeField] Jump Jump;
    [SerializeField] Vision Vision;

    // Update is called once per frame
    void Start(){
        Near();
    }
    void Update()
    {
       
    }
    void ChangeBoolMove(){
        MoveEnemy.Walking=!MoveEnemy.Walking;
    }
    void ChangeBoolCheck(){
        GroundCheck.On =! GroundCheck.On;
    }
    void Near(){
        bool Check = Vision.near;
        float time=0;
        if(Check){
            StateJump();
            time=4f;
        }else{
            StateIdle();
            time=0.2f;
        }
        StartCoroutine(Waiting(time));
    }
    void StateJump(){
        MoveEnemy.Walking=false;
        GroundCheck.On=false;
        Jump.Jumping();
    }
    void StateIdle(){
        MoveEnemy.Walking=true;
        GroundCheck.On =true;
    }
    IEnumerator Waiting(float value){
        yield return new WaitForSeconds(value);
        Near();
    }
}
