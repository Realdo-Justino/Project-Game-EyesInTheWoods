using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Activator : MonoBehaviour
{
    [SerializeField] DownwordAtk DownwordAtk;
    [SerializeField] Downword_Chosing Downword_Chosing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D colisor) {
        if((colisor.tag=="Top")&&(DownwordAtk.enabled!=false)){
            DownwordAtk.enabled = false;
            Downword_Chosing.enabled = true;
        }
    }
}
