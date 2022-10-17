using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(ChanpionStatus))]
public class TestChanpion : MonoBehaviour
{
    [SerializeField] ChanpionStatus _chanpionStatus;
    private void Start()
    {
        _chanpionStatus = gameObject.GetComponent<ChanpionStatus>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Skill1CoolDown(8f, 70);
        }
    }
    public async void AutoAttackCoolDown(float AS)
    {
        AutoAttack(AS,_chanpionStatus.AttackDamage);
        _chanpionStatus._skillCD[0] = true;
        await Task.Delay(TimeSpan.FromSeconds(1/AS));
        _chanpionStatus._skillCD[0] = false;
    }
    public async void Skill1CoolDown(float CD, float Cost)
    {
        _chanpionStatus._skillCD[0] = true;
        Skill1();
        await Task.Delay(TimeSpan.FromSeconds(CD - (CD / (_chanpionStatus.CoolDownReduction / 100 + _chanpionStatus.CoolDownReduction))));
        _chanpionStatus._skillCD[0] = false;
    }
    public async void Skill2CoolDown(float CD, float Cost)
    {
        _chanpionStatus._skillCD[1] = true;
        Skill2();
        await Task.Delay(TimeSpan.FromSeconds(CD - (CD / (_chanpionStatus.CoolDownReduction / 100 + _chanpionStatus.CoolDownReduction))));
        _chanpionStatus._skillCD[1] = false;
    }
    public async void Skill3CoolDown(float CD, float Cost)
    {
        _chanpionStatus._skillCD[2] = true;
        Skill3();
        await Task.Delay(TimeSpan.FromSeconds(CD - (CD / (_chanpionStatus.CoolDownReduction / 100 + _chanpionStatus.CoolDownReduction))));
        _chanpionStatus._skillCD[2] = false;
    }
    public async void Skill4CoolDown(float CD, float Cost)
    {
        _chanpionStatus._skillCD[3] = true;
        SkillUltimate();
        await Task.Delay(TimeSpan.FromSeconds(CD - (CD / (_chanpionStatus.CoolDownReduction / 100 + _chanpionStatus.CoolDownReduction))));
        _chanpionStatus._skillCD[3] = false;
    }
    public void AutoAttack(float CD, float Damage) { }

    void Skill1() { }
    void Skill2() { }
    void Skill3() { }
    void SkillUltimate() { }
}
