using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_AnimationParameter : MonoBehaviour
{
    public  const string FORWARD_PARAM = "forward";
    public  const string RIGHT_PARAM = "right";
    public  const string CROUCH_PARAM = "crouch";
    public  const string SPRINT_PARAM = "sprint";
    public  const string ATTACK_PARAM = "attack";

    public static int ForwardAxisParam = Animator.StringToHash(FORWARD_PARAM);
    public static int RightAxisParam = Animator.StringToHash(RIGHT_PARAM);
    public static int CrouchParam = Animator.StringToHash(CROUCH_PARAM);
    public static int SprintParam = Animator.StringToHash(SPRINT_PARAM);
    public static int AttackParam = Animator.StringToHash(ATTACK_PARAM);
}
