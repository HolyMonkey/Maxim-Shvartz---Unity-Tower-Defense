using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour {

    public GroundGesture HeroGesture;
    public Transform HeroSpawnPoint;
    public GameObject HeroPrefab;

    private HeroFactory _factory;

	void Start ()
    {
        _factory = new HeroFactory();
        _factory.CreateHero(HeroPrefab, HeroSpawnPoint.position, HeroGesture);	
	}
}
