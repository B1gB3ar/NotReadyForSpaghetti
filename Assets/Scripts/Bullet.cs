using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public int dam;
    public bool isPlayer;
    public float bulletTime = 5.0f;
    float currBulletTime;

    //public bool affectedByGrav;
    //public bool rico;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        currBulletTime += Time.deltaTime;
        if (currBulletTime >= bulletTime)
        {
            Destroy(gameObject);
        }
    }

    public void initBull(int gunIdent, bool playerBull)
    {
        //switch (gunIdent){
            //default:
                dam = 10;
                bulletTime = 10;

                //affectedByGrav = false;
                //rico = false;
               // break;
        //}
        isPlayer = playerBull;
    }

    void OnCollisionEnter(Collision colliInfo)
    {
        if (colliInfo.gameObject.tag == "player")
        {
            //call damage on player
            Destroy(gameObject);
        }
        else if (colliInfo.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            if (isPlayer)
            {
                //call damage on enemy
            }
        }
        else if (colliInfo.gameObject.tag == "bullet")
        {
            //ignore?
        }
        else if (colliInfo.gameObject.tag == "pack")
        {
            //ignore?
        }
        else//terrain
        {
            Destroy(gameObject);
            //TODO
            //check penetration and recoil
        }
    }
}
