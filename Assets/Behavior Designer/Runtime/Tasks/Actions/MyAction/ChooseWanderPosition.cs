using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("计算出更新的路径")]
public class ChooseWanderPosition : Action
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("最长距离")]
    public float wanderDistance;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("存放目标地的变量")]
    public SharedVector3 destination;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;

    public override TaskStatus OnUpdate()
    {

        do
        {
            Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0f, UnityEngine.Random.Range(-1f, 1f));
            direction *= wanderDistance;
            destination.Value = monster.Value.transform.position + direction;
        } while (System.Math.Abs(destination.Value.x) > 20 || System.Math.Abs(destination.Value.z) > 30);

        return TaskStatus.Success;
    }
}

