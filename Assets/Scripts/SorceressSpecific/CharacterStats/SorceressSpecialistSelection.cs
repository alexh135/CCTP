using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SorceressSpecialistSelection : MonoBehaviour
{
    // references to scripts
    public SorceressSpecialistSkillUnlock sorceressSpecialistSkillUnlock;
    public SkillPointHandler skillPointsHandler;
    public SorceressAbilityEffects sorceressAbilityEffects;
    public SorceressClass sorceressClass;
    public SorceressMovement sorceressMovement;

    // references to public UI sliders
    public Slider healthSplashSlider;
    public Slider speedSlider;
    public Slider damageSlider;
    public Slider jumpSlider;
    public Slider fireBallSlider;
    public Slider levitateSlider;
    public Slider waterBallSlider;
    public Slider lightningSlider;
    public Slider freezeSlider;
    public Slider flySlider;

    // references to public toggles
    public Toggle healthSplashToggle;
    public Toggle speedToggle;
    public Toggle damageToggle;
    public Toggle jumpToggle;
    public Toggle fireBallToggle;
    public Toggle levitateToggle;
    public Toggle waterBallToggle;
    public Toggle lightningToggle;
    public Toggle freezeToggle;
    public Toggle flyToggle;

    // references to public bools
    public bool healthSplashSelected;
    public bool speedSelected;
    public bool damageSelected;
    public bool jumpSelected;
    public bool fireBallSelected;
    public bool levitateSelected;
    public bool waterBallSelected;
    public bool lightningSelected;
    public bool freezeSelected;
    public bool flySelected;

    // references to public integers
    public int healSplashUpgrade;
    public int speedUpgrade;
    public int damageUpgrade;
    public int jumpUpgrade;
    public int fireBallUpgrade;
    public int levitateUpgrade;
    public int waterBallUpgrade;
    public int lightningUpgrade;
    public int freezeUpgrade;
    public int flyUpgrade;
    public int maxUpgrade;

    public int skillsSelected;
    public int maxSkillsSelected = 4;

    public void Start()
    {
        // slider values set
        healthSplashSlider.value = 0;
        freezeSlider.value = 0;
        damageSlider.value = 0;
        jumpSlider.value = 0;
        fireBallSlider.value = 0;
        levitateSlider.value = 0;
        waterBallSlider.value = 0;
        lightningSlider.value = 0;
        freezeSlider.value = 0;
        flySlider.value = 0;

        // toggle values set
        healthSplashToggle.isOn = false;
        speedToggle.isOn = false;
        damageToggle.isOn = false;
        jumpToggle.isOn = false;
        fireBallToggle.isOn = false;
        levitateToggle.isOn = false;
        waterBallToggle.isOn = false;
        lightningToggle.isOn = false;
        freezeToggle.isOn = false;
        flyToggle.isOn = false;

        // bool values set
        healthSplashSelected = false;
        speedSelected = false;
        damageSelected = false;
        jumpSelected = false;
        fireBallSelected = false;
        levitateSelected = false;
        waterBallSelected = false;
        lightningSelected = false;
        freezeSelected = false;
        flySelected = false;
    }

    public void Update()
    {
        SkillSelection();
        StopSelection();
    }

    public void StopSelection()
    {
        // if skills are not unlocked set all of the toggles to off
        if (!sorceressSpecialistSkillUnlock.healthSplashPotUnlocked)
        {
            healthSplashToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.SpeedUnlocked)
        {
            speedToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.DamageUnlocked)
        {
            damageToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.jumpUnlocked)
        {
            jumpToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.fireBallUnlocked)
        {
            fireBallToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.levitateUnlocked)
        {
            levitateToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.waterBallUnlocked)
        {
            waterBallToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.lightningUnlocked)
        {
            lightningToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.freezeUnlocked)
        {
            freezeToggle.isOn = false;
        }
        if (!sorceressSpecialistSkillUnlock.flyUnlocked)
        {
            flyToggle.isOn = false;
        }
        // if the number of selected skills is equal to the maximum that can be selected
        if (skillsSelected == maxSkillsSelected)
        {
            // set all toggles to non interactable
            healthSplashToggle.interactable = false;
            freezeToggle.interactable = false;
            damageToggle.interactable = false;
            jumpToggle.interactable = false;
            fireBallToggle.interactable = false;
            levitateToggle.interactable = false;
            waterBallToggle.interactable = false;
            lightningToggle.interactable = false;
            freezeToggle.interactable = false;
            flyToggle.interactable = false;
        }
        // if the number of selected skills is not equal to the maximum that can be selected
        if (skillsSelected != maxSkillsSelected)
        {
            // set all toggle to interactable
            healthSplashToggle.interactable = true;
            freezeToggle.interactable = true;
            damageToggle.interactable = true;
            jumpToggle.interactable = true;
            fireBallToggle.interactable = true;
            levitateToggle.interactable = true;
            waterBallToggle.interactable = true;
            lightningToggle.interactable = true;
            freezeToggle.interactable = true;
            flyToggle.interactable = true;
        }
    }

    public void SkillSelection()
    {
        // if toggles are on the skill is selected
        if (sorceressSpecialistSkillUnlock.healthSplashPotUnlocked)
        {
            if (healthSplashToggle.isOn)
            {
                healthSplashSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.SpeedUnlocked)
        {
            if (speedToggle.isOn)
            {
                speedSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.DamageUnlocked)
        {
            if (damageToggle.isOn)
            {
                damageSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.jumpUnlocked)
        {
            if (jumpToggle.isOn)
            {
                jumpSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.fireBallUnlocked)
        {
            if (fireBallToggle.isOn)
            {
                fireBallSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.levitateUnlocked)
        {
            if (levitateToggle.isOn)
            {
                levitateSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.waterBallUnlocked)
        {
            if (waterBallToggle.isOn)
            {
                waterBallSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.lightningUnlocked)
        {
            if (lightningToggle.isOn)
            {
                lightningSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.freezeUnlocked)
        {
            if (freezeToggle.isOn)
            {
                freezeSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (sorceressSpecialistSkillUnlock.flyUnlocked)
        {
            if (flyToggle.isOn)
            {
                flySelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
    }

    public void HealthSplashUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (healSplashUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            healthSplashSlider.value = healthSplashSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase heal amount
            sorceressAbilityEffects.healAmount = sorceressAbilityEffects.healAmount + 2;
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
            sorceressAbilityEffects.sprintSpeedMultiplier = sorceressAbilityEffects.sprintSpeedMultiplier + (int)0.5f;
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
            sorceressAbilityEffects.damageBoostMultiplier = sorceressAbilityEffects.damageBoostMultiplier + (int)0.5f;
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
            sorceressAbilityEffects.doubleJumpMultiplier = sorceressAbilityEffects.doubleJumpMultiplier + (int)0.5f;
        }
    }

    public void FireBallUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (fireBallUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            fireBallSlider.value = fireBallSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase fire ball damage
            sorceressAbilityEffects.fireDamage = sorceressAbilityEffects.fireDamage + 2;
        }
    }

    public void LevitateUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (levitateUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            levitateSlider.value = levitateSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase levitate duration
            sorceressAbilityEffects.levitateMaxTimer = sorceressAbilityEffects.levitateMaxTimer + 1f;
        }
    }

    public void WaterBallUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (waterBallUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            waterBallSlider.value = damageSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase water ball damage
            sorceressAbilityEffects.waterDamage = sorceressAbilityEffects.waterDamage + 1;
        }
    }

    public void LightningUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (lightningUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            lightningSlider.value = lightningSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase lightning damage
            sorceressAbilityEffects.lightningDamage = sorceressAbilityEffects.lightningDamage + 2;
        }
    }

    public void FreezeUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (freezeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            freezeSlider.value = freezeSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase duration of freeze
            sorceressAbilityEffects.maxFreezeTimer = sorceressAbilityEffects.maxFreezeTimer + 2;
        }
    }

    public void FlyUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (flyUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            flySlider.value = flySlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase length of time flying
            sorceressAbilityEffects.maxFlyTimer = sorceressAbilityEffects.maxFlyTimer + 2;
        }
    }
}
