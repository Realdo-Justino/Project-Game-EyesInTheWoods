using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxJump2 : MonoBehaviour
{
    // Start is called before the first frame update
     // Start is called before the first frame update
    Collider2D m_Collider;
    public bool Jump;
    void Start()
    {
         m_Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Jump==true)
        {
             m_Collider.enabled = true;
        }
        else{
             m_Collider.enabled = false;
        }
    }
}
