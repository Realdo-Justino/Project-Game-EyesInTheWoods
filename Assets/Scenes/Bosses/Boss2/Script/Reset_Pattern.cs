using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Pattern : MonoBehaviour
{
    [SerializeField] ClawAtk_Boss2 ClawAtk_Boss2;
    [SerializeField] JumpAtk_Boss2 JumpAtk_Boss2;
    [SerializeField] Box_Activator Box_Activator;
    [SerializeField] Box Box;
    [SerializeField] DownwordAtk DownwordAtk;
    [SerializeField] Downword_Chosing Downword_Chosing;
    [SerializeField]Padrao_boss2 Padrao_boss2;
    [SerializeField]Vida_boss2 Vida_boss2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Reset(){
        ClawAtk_Boss2.enabled = false;
        JumpAtk_Boss2.enabled = false;
        Box.enabled = false;
        Downword_Chosing.enabled = false;
        DownwordAtk.enabled = false;
        Padrao_boss2.enabled = false;
        Vida_boss2.enabled = true;
        
    }
    public void Starting(){
        Padrao_boss2.Stop=false;
        Padrao_boss2.enabled = true;
        Padrao_boss2.GenerateAtk();
        ClawAtk_Boss2.doOnce=true;
        ClawAtk_Boss2.doOnce2=true;
        ClawAtk_Boss2.posicaoPlayer=0;
        DownwordAtk.Topo=true;
        Downword_Chosing.doOnce=true;
        this.enabled = false;
    }
}
