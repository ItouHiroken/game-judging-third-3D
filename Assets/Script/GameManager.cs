using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("今の時間")]

    [Header("MinionSpawn")]
    [Header("ミニオンにかかわる判定")]
    [SerializeField, Tooltip("ミニオン召喚タイマー")]
    float _minionSummonTimer = 0;
    [SerializeField, Tooltip("時間経過によってキャノンミニオンが出てくる間隔が短くなるよ")]
    List<int> _time = new(2);
    [SerializeField, Tooltip("今なんウェーブ目？って教えてくれるくん")]
    float _minionSummonWaveNumber = 1;
    [Header("RedTeam")]
    [SerializeField, Tooltip("前衛.後衛.キャノン.スーパーの順番で入れて！")]
    List<GameObject> _minionsRed = new(4);
    [SerializeField, Tooltip("トップ.ミッド.ボットの順番で入れて！")]
    List<GameObject> _minionRedSummonPoint = new(3);
    [SerializeField, Tooltip("トップ.ミッド.ボットの順番で入れて！")]
    List<bool> _minionRedSuperSummon = new(3) { false, false, false };
    [Header("BlueTeam")]
    [SerializeField, Tooltip("前衛.後衛.キャノン.スーパーの順番で入れて！")]
    List<GameObject> _minionsBlue = new(4);
    [SerializeField, Tooltip("トップ.ミッド.ボットの順番で入れて！")]
    List<GameObject> _minionBlueSummonPoint = new(3);
    [SerializeField, Tooltip("トップ.ミッド.ボットの順番で入れて！")]
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
                Debug.Log("なんかおかしいぞ！");
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
