using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour {

    public int ammoCost;
    public int bulletForce;
    public int gunIdent;
    public GameObject shooterObj;
    //public BaseGun shooterGun;
    public GameObject bulletObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void shoot()
    {
        GameObject newObj = Instantiate(bulletObj,
            transform.position + shooterObj.transform.forward * 2,
            transform.rotation) as GameObject;
        newObj.GetComponent<Rigidbody2D>().AddForce(shooterObj.transform.forward * //shooterGun.bulletSpeed);
            5000.0f);
        newObj.GetComponent<Bullet>().initBull(gunIdent, true);
    }

}
