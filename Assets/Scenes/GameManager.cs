using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float _minionSummonTimer = 0;
    float _minionSummonWaveNumber = 1;
    [Header("MinionSpawn")]
    [Header("RedTeam")]
    [SerializeField, Tooltip("前衛ミニオン.後衛ミニオン.キャノンミニオン.スーパーミニオンの順番で入れて！")]
    List<GameObject> _minionsRed = new(4);
    [SerializeField, Tooltip("トップ.ミッド.ボットの順番で入れて！")] 
    List<GameObject> _minionRedSummonPoint = new(3);
    [SerializeField, Tooltip("トップ.ミッド.ボットの順番で入れて！")] 
    List<bool> _minionRedSuperSummon = new(3);
    [Header("BlueTeam")]


    private void Update()
    {
        _minionSummonTimer += Time.deltaTime;

        switch (_minionSummonWaveNumber / 3)
        {
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Log("なんかおかしいぞ！");
                break;
        }
    }
    void MinionWaveRedNormal()
    {
    }
    void MinionWaveRedCannon()
    {
        _minionSummonWaveNumber++;
    }
    void MinionWaveRedSuper()
    {
        _minionSummonWaveNumber++;
    }
    IEnumerator MinionWaveRedNormal()
    {
        Instantiate(_minionsRed[0]):
        yield return new WaitForSeconds(0.5f);
        yield return new WaitForSeconds(0.5f);
        yield return new WaitForSeconds(0.5f);
        yield return new WaitForSeconds(0.5f);
        yield return new WaitForSeconds(0.5f);
        _minionSummonWaveNumber++;
    }
}
