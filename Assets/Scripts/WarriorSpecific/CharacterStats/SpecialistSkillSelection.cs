using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialistSkillSelection : MonoBehaviour
{
    // references to scripts
    public WarriorSpecialistSkillUnlock warriorSpecialistSkillUnlock;
    public SkillPointHandler skillPointsHandler;
    public WarriorAbilityEffects warriorAbilityEffects;
    public WarriorClass warriorClass;
    public CharacterMovement characterMovement;

    // references to public UI sliders
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

    // references to public toggles
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

    // references to public bools
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

    // references to public integers
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
        // slider values set
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

        // toggle values set
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

        // bool values set
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
        // if skills are not unlocked set all of the toggles to off
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
        // if the number of selected skills is equal to the maximum that can be selected
        if (skillsSelected == maxSkillsSelected)
        {
            // set all toggles to non interactable
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
        // if the number of selected skills is not equal to the maximum that can be selected
        if (skillsSelected != maxSkillsSelected)
        {
            // set all toggle to interactable
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
        // if toggles are on the skill is selected
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
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (bargeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            bargeSlider.value = bargeSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase the distane the player can barge
            warriorAbilityEffects.bargeDIstance = warriorAbilityEffects.bargeDIstance + (int)5f;
        }
    }

    public void SpeedUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (speedUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            speedSlider.value = speedSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase the speed the player can run
            warriorAbilityEffects.sprintSpeedMultiplier = warriorAbilityEffects.sprintSpeedMultiplier + (int)0.5f;
        }
    }

    public void DamageUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (damageUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            damageSlider.value = damageSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase the damage the player can inflict
            warriorAbilityEffects.damageBoostMultiplier = warriorAbilityEffects.damageBoostMultiplier + (int)0.5f;
        }
    }

    public void JumpUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (jumpUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            jumpSlider.value = jumpSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase the height that the player can jump
            warriorAbilityEffects.doubleJumpMultiplier = warriorAbilityEffects.doubleJumpMultiplier + (int)0.5f;
        }
    }

    public void GlitchUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (glitchUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            glitchSlider.value = glitchSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase the distance the player can jump
            warriorAbilityEffects.glitchDistance = warriorAbilityEffects.glitchDistance + 5;
        }
    }

    public void TimeUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (timeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            timeSlider.value = timeSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase how slow time becomes
            warriorAbilityEffects.slowSpeedMultiplier = warriorAbilityEffects.slowSpeedMultiplier + (int)0.5f;
        }
    }

    public void AxeUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (axeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            axeSlider.value = damageSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase axe damage
            warriorAbilityEffects.axeDamage = warriorAbilityEffects.axeDamage + 2;
        }
    }

    public void ShieldUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (shieldUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            shieldSlider.value = shieldSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase the amount of time the shield is on for
            warriorAbilityEffects.shieldTimeLimiter = warriorAbilityEffects.shieldTimeLimiter + 1f;
        }
    }

    public void SpearUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (spearUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            spearSlider.value = spearSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase spear damage 
            warriorAbilityEffects.spearDamage = warriorAbilityEffects.spearDamage + 2;
        }
    }

    public void HealUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (healUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            healSlider.value = healSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase the amount that is healed when skill is used
            warriorAbilityEffects.healAmount = warriorAbilityEffects.healAmount + 1;
        }
    }
}
