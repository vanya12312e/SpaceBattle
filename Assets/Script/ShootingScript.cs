using System.Collections;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject Bullet;
    [SerializeField] private float reloadTime;
    [SerializeField] private Transform firePosition;
    private bool canShoot = true;

    private void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)  
        {
            StartCoroutine(ShootCoroutine());
            canShoot = false;
        }
    }

    private IEnumerator ShootCoroutine()
    {

        GameObject bulletInstance = Instantiate(Bullet, firePosition.position, Quaternion.identity, firePosition);
        bulletInstance.transform.eulerAngles = new Vector3(0f, 0, 90f);
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }

    
}