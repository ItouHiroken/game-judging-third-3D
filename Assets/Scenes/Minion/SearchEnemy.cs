using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// �~�j�I���̍U���͈͂�ݒ肵�A���̍U���͈͂ɂ���X�N���v�g�B
/// �e�I�u�W�F�N�g��������Q�Ƃ��Ăق���
/// </summary>
public class SearchEnemy : MonoBehaviour
{
    [SerializeField] List<GameObject> _redChamp = new();
    [SerializeField] List<GameObject> _blueChamp = new();
    [Tooltip("�e�I�u�W�F�N�g�ɓn������")] public GameObject Target;
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
            //�|�������肪�͈͊O�̎��Ɍo���l���炦�Ȃ��o�O������
            for (int j = 0; j < i; j++)
            {
                // _redChamp[j].GetComponent<�X�e�[�^�X�p�̃X�N���v�g>().exp += transform.root.gameObject.GetComponent<�X�e�[�^�X�p�̃X�N���v�g>().exp / j;
            }
        }
        else
        {
            int i = _blueChamp.Count;
            //�|�������肪�͈͊O�̎��Ɍo���l���炦�Ȃ��o�O������
            for (int j = 0; j < i; j++)
            {
                // _blueChamp[j].GetComponent<�X�e�[�^�X�p�̃X�N���v�g>().exp += transform.root.gameObject.GetComponent<�X�e�[�^�X�p�̃X�N���v�g>().exp / j;
            }
        }
    }
}
