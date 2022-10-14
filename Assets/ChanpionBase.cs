using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChanpionBase : MonoBehaviour
{
    private float _attackDamage;
    private float _attackSpeed;
    private float _abilityPower;
    private float _criticalStrikeChance;
    private float _criticalStrikeDamage;
    private float _lifeSteal;
    private float _cooldownReduction;
    private float _spellVamp;

    private float _armor;
    private float _armorPenetration;

    private float _magicResistance;
    private float _magicPenetration;

    private float _tenacity;

    private float _hp;
    private float _healthRegeneration;
    private float _fullHp;

    private float _mana;
    private float _MagicPenetration;
    private float _fullMana;

    private float _movementSpeed;

    private float _deathTimer;
    private float _gold;
    private float _experience;
    private float _fullExperience;

    void AutoAttack() { }
    void Skill1() {}
    void Skill2() {}
    void Skill3() {}
    void SkillUltimate() {}


}
