using UnityEngine;

public class AnimateScript : MonoBehaviour
{
     Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)){
            anim.SetInteger("run_jump",0);
        }
        if( Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d")){
            anim.SetInteger("run_jump",0);
        }
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            //anim.Play("locom_m_jogging_30f", 0, 0f);
            anim.SetInteger("run_jump",1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //anim.Play("dance_m_flossing_40f", 0, 0f);
            anim.SetInteger("run_jump",2);
        }
        
        
        
        //anim.Play("idle_m_1_200f", 0, 0f);
        
    }
}
