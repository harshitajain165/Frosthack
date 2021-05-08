using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator anime; 

   

    public void ButtonEmbarrass(){
        anime.SetTrigger("Embarasss");
    }
    public void ButtonWriting(){
        anime.SetTrigger("Writing");
    }
    public void ButtonTravel(){
        anime.SetTrigger("Travel");
    }
    public void ButtonShow(){
        anime.SetTrigger("Show");
    }
    public void ButtonPleased(){
        anime.SetTrigger("Pleased");
    }
    public void ButtonIdle(){
        anime.SetTrigger("Idle");
    }
    public void ButtonHide(){
        anime.SetTrigger("Hide");
    }
    public void ButtonCongratulate(){
        anime.SetTrigger("Congratulate");
    }
    public void ButtonClicked(){
        anime.SetTrigger("Clicked");
    }
    public void ButtonSuccess(){
        anime.SetTrigger("Success");
    }

}
