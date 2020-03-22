using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyConditionals")]
[TaskDescription("判断范围内是否有玩家")]
public class FindPlayer : Conditional
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("距离")]
    public float ranage=20;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("判断距离的玩家")]
    public SharedGameObject player;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;

    public override TaskStatus OnUpdate()
    {
        float d = Vector3.Distance(player.Value.transform.position, monster.Value.transform.position);
        if ( d> ranage || d < 3) 
        {
            return TaskStatus.Failure;
        }
        return TaskStatus.Success;
    }
}