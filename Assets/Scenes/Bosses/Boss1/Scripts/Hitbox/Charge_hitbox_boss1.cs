using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge_hitbox_boss1 : MonoBehaviour
{
    // Start is called before the first frame update
   Collider2D m_Collider;
    public bool charge;
    public float contador;

    [SerializeField]
    Boss1_padrao1 Boss1_padrao1;
    void Start()
    {
         m_Collider = GetComponent<Collider2D>();
         Boss1_padrao1.charging_hitbox=true;

    }

    // Update is called once per frame
    void Update()
    {
        contador+=Time.deltaTime;
        if (contador<8)
        {
             m_Collider.enabled = true;
        }
        else{
             m_Collider.enabled = false;
             contador=0;
             Boss1_padrao1.charging_hitbox=false;
        }
    }
}
