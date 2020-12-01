using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{

    public float damageAmount = 1f;

    public float range = 150f;

    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyTarget target = hit.transform.GetComponent<EnemyTarget>();
            if (target != null)
            {
                target.DamageReceived(damageAmount);
            }
        }
    }
}
