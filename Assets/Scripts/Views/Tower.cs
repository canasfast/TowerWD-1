using CanasSource;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerState
{
    Idle,
    Attack
}

public abstract class Tower : MonoBehaviour
{
    protected CircleCollider2D theCC;
    public TowerState state { get; protected set; }
    //public TowerModel model { get; private set; }
    public TowerStat stat { get; private set; }
    public Transform target { get; protected set; }
    public Cooldown attackCooldown { get; protected set; } = new();
    private bool isStop;

    [SerializeField] protected Transform firePointPos;
    [SerializeField] protected Bullet bulletPrefab;
    public void Init(TowerStat _stat)
    {
        //model = _model;
        stat = _stat;
        theCC = GetComponent<CircleCollider2D>();
        theCC.radius = stat.atkRange.Value;
    }

    private void Update()
    {
        if (isStop) return;
        LogicUpdate(Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (isStop) return;
        LogicUpdate(Time.fixedDeltaTime);
    }

    protected virtual void LogicUpdate(float deltaTime)
    {

    }

    protected virtual void PhysicUpdate(float deltaTime)
    {

    }
}
