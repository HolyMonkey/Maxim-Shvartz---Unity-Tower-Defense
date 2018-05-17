using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Utility;
using Assets.Scripts.Gameplay;

public class Tower : MonoBehaviour {

    public GameObject Bullet;
	public Transform ShootPivot;
    private GameObjectPool TowerPool;

    private void Start()
    {
        TowerPool = new GameObjectPool(1000, Bullet);        
    }

    void Update ()
    {
        for (int i = 0; i < 100; i++)
        {
            var bullet = TowerPool.AllocateObject();
            if (bullet != null)
            {
                var bulletComponent = bullet.GetComponent<Bullet>();
                bulletComponent.OnEnd += TowerPool.DestroyObject;
                bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 100);
            }
        }
	}
}
