using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle_hitbox_boss1 : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D m_Collider;
    public bool charge;
    void Start()
    {
         m_Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (charge==true)
        {
             m_Collider.enabled = false;
        }
        else{
             m_Collider.enabled = true;
        }
    }
}
