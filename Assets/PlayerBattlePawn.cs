using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattlePawn : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // anim = GetComponent<Animator>();
    }

    public void InitialSetup()
    {
        //Nothing to do yet
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed Space");
            if (Input.GetKeyDown(KeyCode.Space)) anim.SetTrigger("CharacterSpellUsed");
            Debug.Log("after press");
        }
    }
}
