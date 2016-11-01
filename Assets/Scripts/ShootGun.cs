using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour {

    public int ammoCost;
    public float bulletForce = 1000.0f;
    public int gunIdent = 0;
    public GameObject shooterObj;
    //public BaseGun shooterGun;
    public GameObject bulletObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void shoot()
    {
        GameObject newObj = Instantiate(bulletObj,
            transform.position + shooterObj.transform.forward * 2,
            transform.rotation) as GameObject;
        newObj.GetComponent<Rigidbody2D>().AddForce(shooterObj.transform.forward //shooterGun.bulletSpeed);
            );
        newObj.GetComponent<Bullet>().initBull(gunIdent, true);
    }

}
