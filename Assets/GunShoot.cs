using System.Runtime.Versioning;
using System.Reflection;
using System.Runtime;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GunShoot : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    
    public GameObject hitEffect;
    public GameObject fireEffect;
    public GameObject fireEffectPos;

    public Camera fpsCam;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        RaycastHit hit;
        Instantiate(hitEffect,fireEffectPos.transform.position,fireEffectPos.transform.rotation);
        if (Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward, out hit, range))
        {
            // Debug.Log(hit.transform.position)
            Debug.Log(hit.transform.name);
            Hit target = hit.transform.GetComponent<Hit>();
            if (target != null)
            {
                target.TakeDamage(damage);
                
            }
        }
        
    }
}
