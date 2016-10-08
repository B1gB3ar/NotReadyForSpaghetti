using UnityEngine;
using System.Collections;

public class Bullet{
    public int damage;
    public int range;
    public double penetration;
    public int bulletSpeed;

    public bool affectedByGravity;
    public bool ricochet;

    public Bullet(int dam, int ran, double pen, int spd, bool grav, bool ric)
    {
        damage = dam;
        range = ran;
        penetration = pen;
        bulletSpeed = spd;
        affectedByGravity = grav;
        ricochet = ric;
    }

}
