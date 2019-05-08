using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSystem : MonoBehaviour
{
    List<ISkill> HeroSkill = new List<ISkill>();
    //Ӣ�ۼ��ܶ����б�
    List<ISkill> EquipmentSkill = new List<ISkill>();
    //װ�����ܶ����б�
    private Individual individual;
    // Start is called before the first frame update
    void Start()
    {
        individual = GetComponent<Individual>();

        HeroSkill.Add(new AOESkill(0,10));
        HeroSkill.Add(new AOESkill(1,1));
        HeroSkill.Add(new AOESkill(2,1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// �ͷż���
    /// </summary>
    /// <param name="index"></param>
    public void ReleaseSkill(int index)
    {
        Debug.Log("Release Skill " + index);

        if(index >= HeroSkill.Count){ return; }

        HeroSkill[index].ReleaseSkill(gameObject);
    }

    public void ReceiveMessage(Individual attacker,float damage)
    {
        //Ϊ������ԣ���ʱʲôҲ����
        //foreach (var skill in HeroSkill)
        //{
        //    skill.DealAttackMessage(attacker, damage);
        //}
        //foreach (var skill in EquipmentSkill)
        //{
        //    skill.DealAttackMessage(attacker, damage);
        //}
    }
}
