using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public AudioSource ses;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void BasTusu()
    {
        anim.SetTrigger("bas");
        ses.Play();
    }
}
