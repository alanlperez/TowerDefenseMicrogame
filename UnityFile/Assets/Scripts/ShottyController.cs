using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShottyController : BaseTower
{
    public override void Shoot()
    {
        for (int j = 0; j < bulletSpawnPositions.Length; j++)
            for(int i = 0; i < 5; i++)
                Instantiate(bullet, bulletSpawnPositions[j].transform.position, transform.rotation* Quaternion.Euler(0, 0, (i*5)-15f));// (i = 0) = -15, (i = 1) = -10, (i = 2) = -5, (i = 3) = 0, (i = 4) = 5
        Instantiate(flash, bulletSpawnPositions[0].transform.position, transform.rotation);
        scr.Play();
        cools = shootSpeed;
        base.Shoot();
    }
}

