using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MinionBase : MonoBehaviour
{
    [SerializeField] GameObject _hateRange;
    [SerializeField] List<string> _enemyTag = new(3);
    GameObject _child;
    SearchEnemy _search;
    GameObject _nexus;
    protected void Start()
    {
        _child = transform.GetChild(0).gameObject;
        _search = _child.GetComponent<SearchEnemy>();
        _nexus = GameObject.FindGameObjectWithTag("");
    }
    private void Update()
    {

    }
    protected void Attack(GameObject target)
    {
    }
    protected void Move(GameObject target)
    {

    }
}