using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialistSkillSelection : MonoBehaviour
{
    public WarriorSpecialistSkillUnlock warriorSpecialistSkillUnlock;
    public SkillPointHandler skillPointsHandler;
    public WarriorAbilityEffects warriorAbilityEffects;
    public WarriorClass warriorClass;
    public CharacterMovement characterMovement;

    public Slider bargeSlider;
    public Slider speedSlider;
    public Slider damageSlider;
    public Slider jumpSlider;
    public Slider glitchSlider;
    public Slider timeSlider;
    public Slider axeSlider;
    public Slider shieldSlider;
    public Slider spearSlider;
    public Slider healSlider;

    public Toggle bargeToggle;
    public Toggle speedToggle;
    public Toggle damageToggle;
    public Toggle jumpToggle;
    public Toggle glitchToggle;
    public Toggle timeToggle;
    public Toggle axeToggle;
    public Toggle shieldToggle;
    public Toggle spearToggle;
    public Toggle healToggle;

    public bool bargeSelected;
    public bool speedSelected;
    public bool damageSelected;
    public bool jumpSelected;
    public bool glitchSelected;
    public bool timeSelected;
    public bool axeSelected;
    public bool shieldSelected;
    public bool spearSelected;
    public bool healSelected;

    public int bargeUpgrade;
    public int speedUpgrade;
    public int damageUpgrade;
    public int jumpUpgrade;
    public int glitchUpgrade;
    public int timeUpgrade;
    public int axeUpgrade;
    public int shieldUpgrade;
    public int spearUpgrade;
    public int healUpgrade;
    public int maxUpgrade;

    public int skillsSelected;
    public int maxSkillsSelected = 4;

    public void Start()
    {
        bargeSlider.value = 0;
        spearSlider.value = 0;
        damageSlider.value = 0;
        jumpSlider.value = 0;
        glitchSlider.value = 0;
        timeSlider.value = 0;
        axeSlider.value = 0;
        shieldSlider.value = 0;
        spearSlider.value = 0;
        healSlider.value = 0;

        bargeToggle.isOn = false;
        speedToggle.isOn = false;
        damageToggle.isOn = false;
        jumpToggle.isOn = false;
        glitchToggle.isOn = false;
        timeToggle.isOn = false;
        axeToggle.isOn = false;
        shieldToggle.isOn = false;
        spearToggle.isOn = false;
        healToggle.isOn = false;

        bargeSelected = false;
        speedSelected = false;
        damageSelected = false;
        jumpSelected = false;
        glitchSelected = false;
        timeSelected = false;
        axeSelected = false;
        shieldSelected = false;
        spearSelected = false;
        healSelected = false;
    }

    public void Update()
    {
        SkillSelection();
        StopSelection();
    }

    public void StopSelection()
    {
        if (!warriorSpecialistSkillUnlock.BargeUnlocked)
        {
            bargeToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.SpeedUnlocked)
        {
            speedToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.DamageUnlocked)
        {
            damageToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.jumpUnlocked)
        {
            jumpToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.glitchUnlocked)
        {
            glitchToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.timeUnlocked)
        {
            timeToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.axeUnlocked)
        {
            axeToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.shieldUnlocked)
        {
            shieldToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.spearUnlocked)
        {
            spearToggle.isOn = false;
        }
        if (!warriorSpecialistSkillUnlock.healUnlocked)
        {
            healToggle.isOn = false;
        }
        if (skillsSelected == maxSkillsSelected)
        {
            bargeToggle.interactable = false;
            spearToggle.interactable = false;
            damageToggle.interactable = false;
            jumpToggle.interactable = false;
            glitchToggle.interactable = false;
            timeToggle.interactable = false;
            axeToggle.interactable = false;
            shieldToggle.interactable = false;
            spearToggle.interactable = false;
            healToggle.interactable = false;
        }
        if (skillsSelected != maxSkillsSelected)
        {
            bargeToggle.interactable = true;
            spearToggle.interactable = true;
            damageToggle.interactable = true;
            jumpToggle.interactable = true;
            glitchToggle.interactable = true;
            timeToggle.interactable = true;
            axeToggle.interactable = true;
            shieldToggle.interactable = true;
            spearToggle.interactable = true;
            healToggle.interactable = true;
        }
    }

    public void SkillSelection()
    {
        if (warriorSpecialistSkillUnlock.BargeUnlocked)
        {
            if (bargeToggle.isOn)
            {
                bargeSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.SpeedUnlocked)
        {
            if (speedToggle.isOn)
            {
                speedSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.DamageUnlocked)
        {
            if (damageToggle.isOn)
            {
                damageSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.jumpUnlocked)
        {
            if (jumpToggle.isOn)
            {
                jumpSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.glitchUnlocked)
        {
            if (glitchToggle.isOn)
            {
                glitchSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.timeUnlocked)
        {
            if (timeToggle.isOn)
            {
                timeSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }   
        if (warriorSpecialistSkillUnlock.axeUnlocked)
        {
            if (axeToggle.isOn)
            {
                axeSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.shieldUnlocked)
        {
            if (shieldToggle.isOn)
            {
                shieldSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.spearUnlocked)
        {
            if (spearToggle.isOn)
            {
                spearSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (warriorSpecialistSkillUnlock.healUnlocked)
        {
            if (healToggle.isOn)
            {
                healSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
    }

    public void BargeUpgrade()
    {
        if (bargeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            bargeSlider.value = bargeSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.bargeDIstance = warriorAbilityEffects.bargeDIstance + (int)5f;
        }
    }

    public void SpeedUpgrade()
    {
        if (speedUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            speedSlider.value = speedSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.sprintSpeedMultiplier = warriorAbilityEffects.sprintSpeedMultiplier + (int)0.5f;
        }
    }

    public void DamageUpgrade()
    {
        if (damageUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            damageSlider.value = damageSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.damageBoostMultiplier = warriorAbilityEffects.damageBoostMultiplier + (int)0.5f;
        }
    }

    public void JumpUpgrade()
    {
        if (jumpUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            jumpSlider.value = jumpSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.doubleJumpMultiplier = warriorAbilityEffects.doubleJumpMultiplier + (int)0.5f;
        }
    }

    public void GlitchUpgrade()
    {
        if (glitchUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            glitchSlider.value = glitchSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.glitchDistance = warriorAbilityEffects.glitchDistance + 5;
        }
    }

    public void TimeUpgrade()
    {
        if (timeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            timeSlider.value = timeSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.slowSpeedMultiplier = warriorAbilityEffects.slowSpeedMultiplier + (int)0.5f;
        }
    }

    public void AxeUpgrade()
    {
        if (axeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            axeSlider.value = damageSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.axeDamage = warriorAbilityEffects.axeDamage + 2;
        }
    }

    public void ShieldUpgrade()
    {
        if (shieldUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            shieldSlider.value = shieldSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.shieldTimeLimiter = warriorAbilityEffects.shieldTimeLimiter + 1f;
        }
    }

    public void SpearUpgrade()
    {
        if (spearUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            spearSlider.value = spearSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.spearDamage = warriorAbilityEffects.spearDamage + 2;
        }
    }

    public void HealUpgrade()
    {
        if (healUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            healSlider.value = healSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            warriorAbilityEffects.healAmount = warriorAbilityEffects.healAmount + 1;
        }
    }
}
