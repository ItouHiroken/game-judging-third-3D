using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("���̎���")]

    [Header("MinionSpawn")]
    [Header("�~�j�I���ɂ�����锻��")]
    [SerializeField, Tooltip("�~�j�I�������^�C�}�[")]
    float _minionSummonTimer = 0;
    [SerializeField, Tooltip("���Ԍo�߂ɂ���ăL���m���~�j�I�����o�Ă���Ԋu���Z���Ȃ��")]
    List<int> _time = new(2);
    [SerializeField, Tooltip("���Ȃ�E�F�[�u�ځH���ċ����Ă���邭��")]
    float _minionSummonWaveNumber = 1;
    [Header("RedTeam")]
    [SerializeField, Tooltip("�O�q.��q.�L���m��.�X�[�p�[�̏��Ԃœ���āI")]
    List<GameObject> _minionsRed = new(4);
    [SerializeField, Tooltip("�g�b�v.�~�b�h.�{�b�g�̏��Ԃœ���āI")]
    List<GameObject> _minionRedSummonPoint = new(3);
    [SerializeField, Tooltip("�g�b�v.�~�b�h.�{�b�g�̏��Ԃœ���āI")]
    List<bool> _minionRedSuperSummon = new(3) { false, false, false };
    [Header("BlueTeam")]
    [SerializeField, Tooltip("�O�q.��q.�L���m��.�X�[�p�[�̏��Ԃœ���āI")]
    List<GameObject> _minionsBlue = new(4);
    [SerializeField, Tooltip("�g�b�v.�~�b�h.�{�b�g�̏��Ԃœ���āI")]
    List<GameObject> _minionBlueSummonPoint = new(3);
    [SerializeField, Tooltip("�g�b�v.�~�b�h.�{�b�g�̏��Ԃœ���āI")]
    List<bool> _minionBlueSuperSummon = new(3) { false, false, false };


    private void Update()
    {
        _minionSummonTimer += Time.deltaTime;

        switch (_minionSummonWaveNumber / 3)
        {
            case 1:
                _minionSummonWaveNumber++;
                break;
            case 2:
                _minionSummonWaveNumber++;
                break;
            default:
                Debug.Log("�Ȃ񂩂����������I");
                break;
        }
    }
    IEnumerator MinionWaveRedNormal()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsRed[0]);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsRed[1]);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator MinionWaveRedCannon()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsRed[0]);
            yield return new WaitForSeconds(0.5f);
        }
        Instantiate(_minionsRed[2]);
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsRed[1]);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator MinionWaveRedSuper()
    {
        Instantiate(_minionsRed[3]);
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsRed[0]);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsRed[1]);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator MinionWaveBlueNormal()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsBlue[0]);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsBlue[1]);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator MinionWaveBlueCannon()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsBlue[0]);
            yield return new WaitForSeconds(0.5f);
        }
        Instantiate(_minionsBlue[2]);
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsBlue[1]);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator MinionWaveBlueSuper()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsBlue[0]);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_minionsBlue[1]);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
