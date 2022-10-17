using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
public class ChanpionStatus : MonoBehaviour
{
    public string ChanpionName { get; set; }
    [SerializeField] private string _chanpionName;
    public float AttackDamage { get; set; }
    [SerializeField] private float _attackDamage;
    public float AttackSpeed { get; set; }
    [SerializeField] private float _attackSpeed;
    public float AbilityPower { get; set; }
    [SerializeField] private float _abilityPower;
    public float CriticalStrikeChance { get; set; }
    [SerializeField] private float _criticalStrikeChance;
    public float CriticalStrikeDamage { get; set; }
    [SerializeField] private float _criticalStrikeDamage;
    public float LifeSteal { get; set; }
    [SerializeField] private float _lifeSteal;
    public float CoolDownReduction { get; set; }
    [SerializeField] private float _cooldownReduction;
    public float SpellVamp { get; set; }
    [SerializeField] private float _spellVamp;
    public float Armor { get; set; }
    [SerializeField] private float _armor;
    public float ArmorPenetration { get; set; }
    [SerializeField] private float _armorPenetration;
    public float MagicResistance { get; set; }
    [SerializeField] private float _magicResistance;
    public float MagicPenetration { get; set; }
    [SerializeField] private float _magicPenetration;

    public int Tenacity { get; set; }
    [SerializeField] private float _tenacity;
    public float HP { get; set; }
    [SerializeField] private float _hp;
    public float HealthRegeneration { get; set; }
    [SerializeField] private float _healthRegeneration;
    public float FullHp { get; set; }
    [SerializeField] private float _fullHp;
    public bool IsUseMana { get; set; }
    [SerializeField] bool _isUseMana;

    public float Mana { get; set; }
    [SerializeField] private float _mana;
    public float MagicRegeneration { get; set; }
    [SerializeField] private float _MagicRegeneration;
    public float FullMana { get; set; }
    [SerializeField] private float _fullMana;

    public float Enagy { get; set; }
    [SerializeField] private float _enagy;
    public float EnagyRegeneration { get; set; }
    [SerializeField] private float _enagyRegeneration;
    public float FullEnagy { get; set; }
    [SerializeField] private float _fullEnagy;

    public float MovementSpeed { get; set; }
    [SerializeField] private float _movementSpeed;

    public float DeathTimer { get; set; }
    [SerializeField] private float _deathTimer;
    public float Gold { get; set; }
    [SerializeField] private float _gold;
    public float GoldRegeneration { get; set; }
    [SerializeField] private float _goldRegeneration;
    public float Experience { get; set; }
    [SerializeField] private float _experience;
    public float FullExperience { get; set; }
    [SerializeField] private float _fullExperience;
    public float Level { get; set; }
    [SerializeField] private float _level;
    public float LevelUpIncreasedHP { get; set; }
    [SerializeField] private float _levelUpIncreasedHP;
    public float LevelUpIncreasedHPRegemeration { get; set; }
    [SerializeField] private float _levelUpIncreasedHPRegemeration;
    public float LevelUpIncreasedMP { get; set; }
    [SerializeField] private float _levelUpIncreasedMP;
    public float LevelUpIncreasedMPRegemeration { get; set; }
    [SerializeField] private float _levelUpIncreasedMPRegemeration;
    public float LevelUpIncreasedAD { get; set; }
    [SerializeField] private float _levelUpIncreasedAD;
    public float LevelUpIncreasedAS { get; set; }
    [SerializeField] private float _levelUpIncreasedAS;
    public float LevelUpIncreasedAR { get; set; }
    [SerializeField] private float _levelUpIncreasedAR;
    public float LevelUpIncreasedMR { get; set; }
    [SerializeField] private float _levelUpIncreasedMR;

    public List<bool> _skillCD = new(4);

    
    public async void Regeneration()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        if (_isUseMana)
        {
            if (_mana < _fullMana)
            {
                _mana += _magicResistance;
            }
        }
        else
        {
            if (_enagy < _fullEnagy)
            {
                _enagy += _enagyRegeneration;
            }
        }
        if (_hp < _fullHp)
        {
            _hp += _healthRegeneration;
        }
        _gold += _goldRegeneration;

        Debug.Log("–ˆ•b‰ñ•œ‚Ìˆ—");
        Regeneration();
    }
}