using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// ミニオンの攻撃範囲を設定し、その攻撃範囲につけるスクリプト。
/// 親オブジェクトがこれを参照してほしい
/// </summary>
public class SearchEnemy : MonoBehaviour
{
    [SerializeField] List<GameObject> _redChamp = new();
    [SerializeField] List<GameObject> _blueChamp = new();
    [Tooltip("親オブジェクトに渡したい")] public GameObject Target;
    [SerializeField, Tooltip("")] bool _isBlue;
    private void Update()
    {
        if (_isBlue)
        {
            Target = _redChamp
            .OrderBy(_ => Vector3.Distance(gameObject.transform.position, _.transform.position))
            .FirstOrDefault();
        }
        else
        {
            Target = _blueChamp
            .OrderBy(_ => Vector3.Distance(gameObject.transform.position, _.transform.position))
            .FirstOrDefault();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedChamp"))
        {
            _redChamp.Add(other.gameObject);
            return;
        }
        if (other.CompareTag("BlueChamp"))
        {
            _blueChamp.Add(other.gameObject);
            return;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RedChamp"))
        {
            _redChamp.Remove(other.gameObject);
            return;
        }
        if (other.CompareTag("BlueChamp"))
        {
            _blueChamp.Remove(other.gameObject);
            return;
        }
    }
    private void OnDestroy()
    {
        if (_isBlue)
        {
            int i = _redChamp.Count;
            //倒した相手が範囲外の時に経験値もらえないバグがある
            for (int j = 0; j < i; j++)
            {
                // _redChamp[j].GetComponent<ステータス用のスクリプト>().exp += transform.root.gameObject.GetComponent<ステータス用のスクリプト>().exp / j;
            }
        }
        else
        {
            int i = _blueChamp.Count;
            //倒した相手が範囲外の時に経験値もらえないバグがある
            for (int j = 0; j < i; j++)
            {
                // _blueChamp[j].GetComponent<ステータス用のスクリプト>().exp += transform.root.gameObject.GetComponent<ステータス用のスクリプト>().exp / j;
            }
        }
    }
}
