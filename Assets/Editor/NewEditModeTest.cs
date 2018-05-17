using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest {

	[Test]
	public void TowerTest()
    {
        GameObject go = new GameObject("Tower");
        go.AddComponent<TowerBehaviour>();
        var unit = NewTarget(new Vector3(0, 0), 0);
        var unit2 = NewTarget(new Vector3(0, 0), 0);
        UnitManager.AddEnemy(unit.gameObject);
        UnitManager.AddEnemy(unit2.gameObject);
    }

    [Test]
    public void FindEnemyStateTest()
    {
        GameObject go = new GameObject("Tower");
        go.AddComponent<TowerBehaviour>();
        var unit = NewTarget(new Vector3(0, 0), 0);
        var unit2 = NewTarget(new Vector3(0, 0), 0);
        UnitManager.AddEnemy(unit.gameObject);
        UnitManager.AddEnemy(unit2.gameObject);
    }


    private UnitStab NewTarget(Vector3 position, int id)
    {
        var go = new GameObject("Target " + id);
        go.transform.position = position;
        return go.AddComponent<UnitStab>();
    }
}
