using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool WActivated=false;
    FireWeapon2 FireWeapon2;
    void Start()
    {
        FireWeapon2=GetComponent<FireWeapon2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(WActivated){
            fire();
            
        }
    }
    void fire(){
        if((Input.GetButtonDown("Fire1"))&&(FireWeapon2.municao>0)){
            FireWeapon2.Fire();
        }
        if(Input.GetButtonDown("Fire3")&&(FireWeapon2.waitFReload==false)&&(FireWeapon2.municao<1)){
            FireWeapon2.Reload();
        }
    }
}
