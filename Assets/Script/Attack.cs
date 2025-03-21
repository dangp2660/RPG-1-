using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator ani;
    private bool isAttack = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isAttack = true;
            ani.SetBool("isAttack", isAttack);
        }
        isAttack = false;
    }
    private void FixedUpdate()
    {
        
    }

    
}
