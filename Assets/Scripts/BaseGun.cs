using UnityEngine;
using System.Collections;

public class BaseGun {
    public int damage;
    public int ammoCost;
    public int range;
    public int coolDown;
    public int bulletSpeed;
    public int recoil;
    public double chanceToAcquire;
    public double penetration; //I'm thinking a value between 0 and 1
                               //that is multiplied by the remaining distance left on the bullet range.
   //Let me know in the GroupMe if you think any of the variable types need changes.
    public bool availToPlayer;
    public bool affectedByGravity;
    public bool ricochet;
    public bool isPlayers;
    

    public BaseGun()
    {
        
    }

    public void fireGun()
    {
        //TODO find player position and orientation
        //TODO move player back by value of recoil variable
        //TODO create bullets with necessary attributes
        //TODO subtract ammoCost
    }
}
