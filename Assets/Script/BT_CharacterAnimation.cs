using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_CharacterAnimation : MonoBehaviour
{
    [SerializeField] Animator characterAnimator = null;
    [SerializeField] float dampForward = 0.3f;
    [SerializeField] float dampRight = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        characterAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateForwardAnimatorParam(float _value)
    {
        if (!characterAnimator) return;
        characterAnimator.SetFloat(BT_AnimationParameter.FORWARD_PARAM, _value, dampForward, Time.deltaTime);
    }

    public void UpdateRightAnimatorParam(float _value)
    {
        if (!characterAnimator) return;
        characterAnimator.SetFloat(BT_AnimationParameter.RightAxisParam, _value, dampRight, Time.deltaTime);

    }

    public void UpdateCrouchAnimatorParam(bool _value)
    {
        if (!characterAnimator) return;
        characterAnimator.SetBool(BT_AnimationParameter.CrouchParam, _value);
    }

    public void UpdateSprintAnimatorParam(bool _value)
    {
        if (!characterAnimator) return;
        characterAnimator.SetBool(BT_AnimationParameter.SprintParam, _value);
    }
    public void UpdateShootAnimatorParam(bool _value)
    {
        if (!characterAnimator) return;
        characterAnimator.SetBool(BT_AnimationParameter.ATTACK_PARAM, _value);
    }
}
