using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    Arma Arma;
    FireWeapon2 FireWeapon2;
    Weapon2 Weapon2;
    bool ChangeW;
    bool Wait=false;
    Recarregar Recarregar;
    Image Image;
    void Start()
    {
        Arma=GetComponent<Arma>();
        FireWeapon2=GetComponent<FireWeapon2>();
        Recarregar=GameObject.Find("Slider").GetComponent<Recarregar>();
        Image=GameObject.Find("Fill").GetComponent<Image>();
        Weapon2=GetComponent<Weapon2>();
        ChangeW=true;
        Arma.WActivated=true;
    }

    // Update is called once per frame
    void Update()
    {
        if((Wait==false)&&(!FireWeapon2.waitFReload)&&(!Arma.waitFReload)){
            Change();
        }
    }
    void Change(){
        if(Input.GetKeyDown(KeyCode.Q)){ 
            ChangeW=!ChangeW;
            Wait=true;
            StartCoroutine(Waiting());
        }
    }
    void Chose(){
        switch(ChangeW){
            case true:Arma.WActivated=true;
            Weapon2.WActivated=false;
            break;
            case false:Arma.WActivated=false;
            Weapon2.WActivated=true;
            break;
        }
        Debug.Log(ChangeW);
        Wait=false;
    }
    IEnumerator Waiting(){
        Weapon2.WActivated=false;
        Arma.WActivated=false;
        Image.enabled=true;
        Recarregar.Incremento=1f/2;
        yield return new WaitForSeconds(2);
        Image.enabled=false;
        Recarregar.Incremento=0f;
        Recarregar.CurrentValue=0f;
        Chose();
    }
    
}
