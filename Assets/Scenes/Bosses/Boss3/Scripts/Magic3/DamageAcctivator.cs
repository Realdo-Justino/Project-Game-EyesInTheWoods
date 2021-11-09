using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAcctivator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Collider2D Dano;
    [SerializeField] Magic3 Magic3;
    [SerializeField] ChangeColor ChangeColor;
    [SerializeField] AttackFall AttackFall;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Begining(){
        StartCoroutine(Showing());
    }
    IEnumerator Waiting(){
        Dano.enabled =true;
        AttackFall.ChangeGravity();
        yield return new WaitForSeconds(4);
        Return();
    }
    void Return(){
        Magic3.Comeback();
        AttackFall.ChangeBack();
        ChangeColor.ChangeFalse();
        Dano.enabled =false;
    }
    IEnumerator Showing(){
        ChangeColor.ChangeTrue();
        yield return new WaitForSeconds(1);
        Meio();
    }
    void Meio(){
        StartCoroutine(Waiting());
    }
}
