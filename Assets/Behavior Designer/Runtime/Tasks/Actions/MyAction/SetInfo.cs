using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("设置怪物的基本属性")]
public class SetInfo : Action
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("玩家")]
    public SharedGameObject player;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;
    

    public override TaskStatus OnUpdate()
    {

        monster.Value = transform.gameObject;
        player.Value = GameObject.FindWithTag("Player");
        return TaskStatus.Success;
    }
}