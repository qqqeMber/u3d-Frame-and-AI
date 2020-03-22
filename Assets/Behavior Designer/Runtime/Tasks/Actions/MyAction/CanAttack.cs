using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyConditionals")]
[TaskDescription("判断对象是否进入攻击范围")]
public class CanAttack : Conditional
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("距离")]
    public float ranage;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("判断距离的玩家")]
    public SharedGameObject player;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;

    public override TaskStatus OnUpdate()
    {

        if (Vector3.Distance(player.Value.transform.position, monster.Value.transform.position) > ranage)
        {
            return TaskStatus.Failure;
        }
        return TaskStatus.Success;
    }
}