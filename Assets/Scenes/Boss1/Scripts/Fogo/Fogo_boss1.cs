using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fogo_boss1 : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D m_Collider;

    [SerializeField]
    public bool fogo=false;

    [SerializeField]
    float contador=0;

    [SerializeField]
    Boss1_padrao1 Boss1_padrao1;
    
    
    

    void Start()
    {
        m_Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((fogo==true)&&(contador<=1000))
        {
             m_Collider.enabled = true;
             contador++;
        }
        else{
             m_Collider.enabled = false;
             fogo=false;
             contador=0;
             Boss1_padrao1.fireing=true;
        }
    }
    
}
