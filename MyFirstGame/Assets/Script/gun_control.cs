

using UnityEngine;

public class gun_control : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30;
    public float fireRate = 15f;
    public Camera fpsCam;
    private float nextTimeToFire = 0f;
    public GameObject impact;
 
   public ParticleSystem muzzle;

    void Update()
    {
        
        
            if (Input.GetMouseButton(0) && Time.time >= nextTimeToFire)
            {
          nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }

        }
        void Shoot()
        {
         muzzle.Play();
        
      RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                UnityEngine.Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * impactForce);
                }
                GameObject impactGO = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));

                Destroy(impactGO, 2f);
           
        }

        }
    
}
