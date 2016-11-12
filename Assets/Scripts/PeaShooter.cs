using UnityEngine;
using System.Collections;

public class PeaShooter : BaseGun {
    
    public PeaShooter()
    {
        //placeholder values
        damage = 10;
        ammoCost = 10;
        range = 10;
        coolDown = 1;
        recoil = 1;
        penetration = 0;
        bulletSpeed = 1;
        chanceToAcquire = 0.1;

        affectedByGravity = false;
        ricochet = false;
        availToPlayer = true;
    }

    void shoot()
    {
        base.fireGun();             //call method in BaseGun class for firing weapon
        //Bullet shot = new Bullet(damage, range, penetration, bulletSpeed, affectedByGravity, ricochet);
        //call constructor for Bullet object

        //note: some weapons will have constructors for multiple bullets, some will have none at all.
    }
}
