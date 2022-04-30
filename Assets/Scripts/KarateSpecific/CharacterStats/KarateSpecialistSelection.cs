using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarateSpecialistSelection : MonoBehaviour
{
    // references to scripts
    public KarateSpecialistSkillUnlock karateSpecialistSkillUnlock;
    public SkillPointHandler skillPointsHandler;
    public KarateAbilityEffects karateAbilityEffects;
    public KarateClass karateClass;
    public KarateMovement karateMovement;

    // references to public UI sliders
    public Slider woodBreakSlider;
    public Slider speedSlider;
    public Slider damageSlider;
    public Slider jumpSlider;
    public Slider wallRunSlider;
    public Slider spinKickSlider;
    public Slider karateChopSlider;
    public Slider zenSlider;
    public Slider firePunchSlider;
    public Slider slideSlider;

    // references to public toggles
    public Toggle woodBreakToggle;
    public Toggle speedToggle;
    public Toggle damageToggle;
    public Toggle jumpToggle;
    public Toggle wallRunToggle;
    public Toggle spinKickToggle;
    public Toggle karateChopToggle;
    public Toggle zenToggle;
    public Toggle firePunchToggle;
    public Toggle slideToggle;

    // references to public bools
    public bool woodBreakSelected;
    public bool speedSelected;
    public bool damageSelected;
    public bool jumpSelected;
    public bool wallRunSelected;
    public bool spinKickSelected;
    public bool karateChopSelected;
    public bool zenSelected;
    public bool firePunchSelected;
    public bool slideSelected;

    // references to public integers
    public int woodBreakUpgrade;
    public int speedUpgrade;
    public int damageUpgrade;
    public int jumpUpgrade;
    public int wallRunUpgrade;
    public int spinKickUpgrade;
    public int karateChopUpgrade;
    public int zenUpgrade;
    public int firePunchUpgrade;
    public int slideUpgrade;
    public int maxUpgrade;

    public int skillsSelected;
    public int maxSkillsSelected = 4;

    public void Start()
    {
        // slider values set
        woodBreakSlider.value = 0;
        firePunchSlider.value = 0;
        damageSlider.value = 0;
        jumpSlider.value = 0;
        wallRunSlider.value = 0;
        spinKickSlider.value = 0;
        karateChopSlider.value = 0;
        zenSlider.value = 0;
        firePunchSlider.value = 0;
        slideSlider.value = 0;

        // toggle values set
        woodBreakToggle.isOn = false;
        speedToggle.isOn = false;
        damageToggle.isOn = false;
        jumpToggle.isOn = false;
        wallRunToggle.isOn = false;
        spinKickToggle.isOn = false;
        karateChopToggle.isOn = false;
        zenToggle.isOn = false;
        firePunchToggle.isOn = false;
        slideToggle.isOn = false;

        // bool values set
        woodBreakSelected = false;
        speedSelected = false;
        damageSelected = false;
        jumpSelected = false;
        wallRunSelected = false;
        spinKickSelected = false;
        karateChopSelected = false;
        zenSelected = false;
        firePunchSelected = false;
        slideSelected = false;
    }

    public void Update()
    {
        SkillSelection();
        StopSelection();
    }

    public void StopSelection()
    {
        // if skills are not unlocked set all of the toggles to off
        if (!karateSpecialistSkillUnlock.woodBreakUnlocked)
        {
            woodBreakToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.SpeedUnlocked)
        {
            speedToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.DamageUnlocked)
        {
            damageToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.jumpUnlocked)
        {
            jumpToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.wallRunningUnlocked)
        {
            wallRunToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.spinKickUnlocked)
        {
            spinKickToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.karateChopUnlocked)
        {
            karateChopToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.zenUnlocked)
        {
            zenToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.firePunchUnlocked)
        {
            firePunchToggle.isOn = false;
        }
        if (!karateSpecialistSkillUnlock.slideUnlocked)
        {
            slideToggle.isOn = false;
        }
        // if the number of selected skills is equal to the maximum that can be selected
        if (skillsSelected == maxSkillsSelected)
        {
            // set all toggles to non interactable
            woodBreakToggle.interactable = false;
            firePunchToggle.interactable = false;
            damageToggle.interactable = false;
            jumpToggle.interactable = false;
            wallRunToggle.interactable = false;
            spinKickToggle.interactable = false;
            karateChopToggle.interactable = false;
            zenToggle.interactable = false;
            firePunchToggle.interactable = false;
            slideToggle.interactable = false;
        }
        // if the number of selected skills is not equal to the maximum that can be selected
        if (skillsSelected != maxSkillsSelected)
        {
            // set all toggle to interactable
            woodBreakToggle.interactable = true;
            firePunchToggle.interactable = true;
            damageToggle.interactable = true;
            jumpToggle.interactable = true;
            wallRunToggle.interactable = true;
            spinKickToggle.interactable = true;
            karateChopToggle.interactable = true;
            zenToggle.interactable = true;
            firePunchToggle.interactable = true;
            slideToggle.interactable = true;
        }
    }

    public void SkillSelection()
    {
        // if toggles are on the skill is selected
        if (karateSpecialistSkillUnlock.woodBreakUnlocked)
        {
            if (woodBreakToggle.isOn)
            {
                woodBreakSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.SpeedUnlocked)
        {
            if (speedToggle.isOn)
            {
                speedSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.DamageUnlocked)
        {
            if (damageToggle.isOn)
            {
                damageSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.jumpUnlocked)
        {
            if (jumpToggle.isOn)
            {
                jumpSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.wallRunningUnlocked)
        {
            if (wallRunToggle.isOn)
            {
                wallRunSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.spinKickUnlocked)
        {
            if (spinKickToggle.isOn)
            {
                spinKickSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.karateChopUnlocked)
        {
            if (karateChopToggle.isOn)
            {
                karateChopSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.zenUnlocked)
        {
            if (zenToggle.isOn)
            {
                zenSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.firePunchUnlocked)
        {
            if (firePunchToggle.isOn)
            {
                firePunchSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (karateSpecialistSkillUnlock.slideUnlocked)
        {
            if (slideToggle.isOn)
            {
                slideSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
    }

    public void WoodBreakUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (woodBreakUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            woodBreakSlider.value = woodBreakSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase wood break damage
            karateAbilityEffects.woodBreakerDamage = karateAbilityEffects.woodBreakerDamage + 2;
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
            karateAbilityEffects.sprintSpeedMultiplier = karateAbilityEffects.sprintSpeedMultiplier + (int)0.5f;
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
            karateAbilityEffects.damageBoostMultiplier = karateAbilityEffects.damageBoostMultiplier + (int)0.5f;
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
            karateAbilityEffects.doubleJumpMultiplier = karateAbilityEffects.doubleJumpMultiplier + (int)0.5f;
        }
    }

    public void WallRunUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (wallRunUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            wallRunSlider.value = wallRunSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase wall run timer
            karateAbilityEffects.maxWallRunTime = karateAbilityEffects.maxWallRunTime + 2;
        }
    }

    public void SpinKickUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (spinKickUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            spinKickSlider.value = spinKickSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase spin kick damage
            karateAbilityEffects.spinKickDamage = karateAbilityEffects.spinKickDamage + 2;
        }
    }

    public void KarateChopUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (karateChopUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            karateChopSlider.value = damageSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase karate chop damage
            karateAbilityEffects.spinKickDamage = karateAbilityEffects.spinKickDamage + 2;
        }
    }

    public void ZenUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (zenUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            zenSlider.value = zenSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase zen timer
            karateAbilityEffects.maxZenTime = karateAbilityEffects.maxZenTime + 2;
        }
    }

    public void FirePunchUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (firePunchUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            firePunchSlider.value = firePunchSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase fire punch damage
            karateAbilityEffects.punchDamage = karateAbilityEffects.punchDamage + 2;
        }
    }

    public void SlideUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (slideUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            slideSlider.value = slideSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase slide timer
            karateAbilityEffects.maxSlideTime = karateAbilityEffects.maxSlideTime + 2;
        }
    }
}
