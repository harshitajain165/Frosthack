using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PortalManager : MonoBehaviour
{
    
    public GameObject MainCamera;
    public GameObject MeditationChamber;

    private Material[] MeditationChamberMaterial;

    void Start()
    {
        MeditationChamberMaterial = MeditationChamber.GetComponent<Renderer>().sharedMaterials;
    }

    void OnTriggerStay(Collider collider)
    {
        Vector3 camPositionInPortalSpace =transform.InverseTransformPoint(MainCamera.transform.position);

        if(camPositionInPortalSpace.y < 0.5f){
            //Disable Stencil Test

            for(int i=0;i<MeditationChamberMaterial.Length;++i)
            {
                MeditationChamberMaterial[i].SetInt("_StencilComp",(int)CompareFunction.Always);
            }
        }
        else{
            //Enable Stencil Test
             for(int i=0;i<MeditationChamberMaterial.Length;++i)
            {
                MeditationChamberMaterial[i].SetInt("_StencilComp",(int)CompareFunction.Equal);
            }
        }
    }
}
