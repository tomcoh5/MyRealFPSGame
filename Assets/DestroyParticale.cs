using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Destroy");
    }


    IEnumerator Destroy (){
        Debg.Log("Enter Destroy");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Enter yeild");
        if(!GetComponent<ParticleSystem>().IsAlive(true))
			{
                GameObject.Destroy(this.gameObject);
            }
    	
    } 
}
