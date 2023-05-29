using System.Collections;
using System.Collections.Generic;

public class TowerModel
{
    public TowerModel() { }
    public TowerModel(string id) => _id = id;

    private string _id;
    private int _level;
    private int _exp;
    private int _atk;
    private float _atkRange;
    private float _atkSpeed;
    private float _projectileSpeed;
    private float _projectileCount;

    public string Id => _id;
    public int Level
    {
        get => _level;
        set
        {
            if (_level == value) return;
            _level = value;
        }
    }

    public int Exp
    {
        get => _exp;
        set
        {
            if (_exp == value) return;
            _exp = value;
        }
    }

    public int Atk
    {
        get => _atk;
        set
        {
            if (_atk == value)
                return;
            _atk = value;
        }
    }

    public float AtkRange
    {
        get => _atkRange;
        set
        {
            if (_atkRange == value)
                return;
            _atkRange = value;
        }
    }

    public float AtkSpeed
    {
        get => _atkSpeed;
        set
        {
            if (_atkSpeed == value) return;
            _atkSpeed = value;
        }
    }

    public float ProjectileSpeed
    {
        get => _projectileSpeed;
        set
        {
            if (_projectileSpeed == value)
                return;
            _projectileSpeed = value;
        }
    }

    public float ProjectileCount
    {
        get => _projectileCount;
        set
        {
            if (_projectileCount == value)
                return;
            _projectileCount = value;
        }
    }
}
