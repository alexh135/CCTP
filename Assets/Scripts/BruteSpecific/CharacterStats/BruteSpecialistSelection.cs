using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BruteSpecialistSelection : MonoBehaviour
{
    // references to scripts
    public BruteSpecialistSkillUnlock bruteSpecialistSkillUnlock;
    public SkillPointHandler skillPointsHandler;
    public BruteAbilityEffects bruteAbilityEffects;
    public BruteClass bruteClass;
    public BruteMovement bruteMovement;

    // references to public UI sliders
    public Slider wreckingBallSlider;
    public Slider speedSlider;
    public Slider damageSlider;
    public Slider jumpSlider;
    public Slider groundAndPoundSlider;
    public Slider rockThrowSlider;
    public Slider bargeSlider;
    public Slider punchSlider;
    public Slider furySlider;
    public Slider rollSlider;

    // references to public toggles
    public Toggle wreckingBallToggle;
    public Toggle speedToggle;
    public Toggle damageToggle;
    public Toggle jumpToggle;
    public Toggle groundAndPoundToggle;
    public Toggle rockThrowToggle;
    public Toggle bargeToggle;
    public Toggle punchToggle;
    public Toggle furyToggle;
    public Toggle rollToggle;

    // references to public bools
    public bool wreckingBallSelected;
    public bool speedSelected;
    public bool damageSelected;
    public bool jumpSelected;
    public bool groundAndPoundSelected;
    public bool rockThrowSelected;
    public bool bargeSelected;
    public bool punchSelected;
    public bool furySelected;
    public bool rollSelected;

    // references to public integers
    public int wreckingBallUpgrade;
    public int speedUpgrade;
    public int damageUpgrade;
    public int jumpUpgrade;
    public int groundAndPoundUpgrade;
    public int rockThrowUpgrade;
    public int bargeUpgrade;
    public int punchUpgrade;
    public int furyUpgrade;
    public int rollUpgrade;
    public int maxUpgrade;

    public int skillsSelected;
    public int maxSkillsSelected = 4;

    public void Start()
    {
        // slider values set
        wreckingBallSlider.value = 0;
        furySlider.value = 0;
        damageSlider.value = 0;
        jumpSlider.value = 0;
        groundAndPoundSlider.value = 0;
        rockThrowSlider.value = 0;
        bargeSlider.value = 0;
        punchSlider.value = 0;
        furySlider.value = 0;
        rollSlider.value = 0;

        // toggle values set
        wreckingBallToggle.isOn = false;
        speedToggle.isOn = false;
        damageToggle.isOn = false;
        jumpToggle.isOn = false;
        groundAndPoundToggle.isOn = false;
        rockThrowToggle.isOn = false;
        bargeToggle.isOn = false;
        punchToggle.isOn = false;
        furyToggle.isOn = false;
        rollToggle.isOn = false;

        // bool values set
        wreckingBallSelected = false;
        speedSelected = false;
        damageSelected = false;
        jumpSelected = false;
        groundAndPoundSelected = false;
        rockThrowSelected = false;
        bargeSelected = false;
        punchSelected = false;
        furySelected = false;
        rollSelected = false;
    }

    public void Update()
    {
        SkillSelection();
        StopSelection();
    }

    public void StopSelection()
    {
        // if skills are not unlocked set all of the toggles to off
        if (!bruteSpecialistSkillUnlock.wreckingBallUnlocked)
        {
            wreckingBallToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.SpeedUnlocked)
        {
            speedToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.DamageUnlocked)
        {
            damageToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.jumpUnlocked)
        {
            jumpToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.groundAndPoundUnlocked)
        {
            groundAndPoundToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.rockThrowUnlocked)
        {
            rockThrowToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.bargeUnlocked)
        {
            bargeToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.punchUnlocked)
        {
            punchToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.furyUnlocked)
        {
            furyToggle.isOn = false;
        }
        if (!bruteSpecialistSkillUnlock.rollUnlocked)
        {
            rollToggle.isOn = false;
        }
        // if the number of selected skills is equal to the maximum that can be selected
        if (skillsSelected == maxSkillsSelected)
        {
            // set all toggles to non interactable
            wreckingBallToggle.interactable = false;
            furyToggle.interactable = false;
            damageToggle.interactable = false;
            jumpToggle.interactable = false;
            groundAndPoundToggle.interactable = false;
            rockThrowToggle.interactable = false;
            bargeToggle.interactable = false;
            punchToggle.interactable = false;
            furyToggle.interactable = false;
            rollToggle.interactable = false;
        }
        // if the number of selected skills is not equal to the maximum that can be selected
        if (skillsSelected != maxSkillsSelected)
        {
            // set all toggle to interactable
            wreckingBallToggle.interactable = true;
            furyToggle.interactable = true;
            damageToggle.interactable = true;
            jumpToggle.interactable = true;
            groundAndPoundToggle.interactable = true;
            rockThrowToggle.interactable = true;
            bargeToggle.interactable = true;
            punchToggle.interactable = true;
            furyToggle.interactable = true;
            rollToggle.interactable = true;
        }
    }

    public void SkillSelection()
    {
        // if toggles are on the skill is selected
        if (bruteSpecialistSkillUnlock.wreckingBallUnlocked)
        {
            if (wreckingBallToggle.isOn)
            {
                wreckingBallSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.SpeedUnlocked)
        {
            if (speedToggle.isOn)
            {
                speedSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.DamageUnlocked)
        {
            if (damageToggle.isOn)
            {
                damageSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.jumpUnlocked)
        {
            if (jumpToggle.isOn)
            {
                jumpSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.groundAndPoundUnlocked)
        {
            if (groundAndPoundToggle.isOn)
            {
                groundAndPoundSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.rockThrowUnlocked)
        {
            if (rockThrowToggle.isOn)
            {
                rockThrowSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.bargeUnlocked)
        {
            if (bargeToggle.isOn)
            {
                bargeSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.punchUnlocked)
        {
            if (punchToggle.isOn)
            {
                punchSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.furyUnlocked)
        {
            if (furyToggle.isOn)
            {
                furySelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
        if (bruteSpecialistSkillUnlock.rollUnlocked)
        {
            if (rollToggle.isOn)
            {
                rollSelected = true;
                skillsSelected = skillsSelected + 1;
            }
        }
    }

    public void WreckingBallUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (wreckingBallUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            wreckingBallSlider.value = wreckingBallSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase wrecking ball damage
            bruteAbilityEffects.wreckingBallDamage = bruteAbilityEffects.wreckingBallDamage + 2;
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
            bruteAbilityEffects.sprintSpeedMultiplier = bruteAbilityEffects.sprintSpeedMultiplier + (int)0.5f;
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
            bruteAbilityEffects.damageBoostMultiplier = bruteAbilityEffects.damageBoostMultiplier + (int)0.5f;
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
            bruteAbilityEffects.doubleJumpMultiplier = bruteAbilityEffects.doubleJumpMultiplier + (int)0.5f;
        }
    }

    public void GroundAndPoundUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (groundAndPoundUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            groundAndPoundSlider.value = groundAndPoundSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase ground and pound damage
            bruteAbilityEffects.poundDamage = bruteAbilityEffects.poundDamage + 2;
        }
    }

    public void RockThrowUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (rockThrowUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            rockThrowSlider.value = rockThrowSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase rock throw damage
            bruteAbilityEffects.rockThrowDamage = bruteAbilityEffects.rockThrowDamage + 2;
        }
    }

    public void BargeUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (bargeUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            bargeSlider.value = damageSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase barge distance
            bruteAbilityEffects.bargeDIstance = bruteAbilityEffects.bargeDIstance + 5;
        }
    }

    public void PunchUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (punchUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            punchSlider.value = punchSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase punch damage
            bruteAbilityEffects.punchDamage = bruteAbilityEffects.punchDamage + 2;
        }
    }

    public void FuryUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (furyUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            furySlider.value = furySlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increae fury damage
            bruteAbilityEffects.furyDamage = bruteAbilityEffects.furyDamage + 2;
        }
    }

    public void RollUpgrade()
    {
        // if the number of upgrades is less than the maximum number of upgrades and the player has mre than 4 skill points
        if (rollUpgrade < maxUpgrade && skillPointsHandler.skillPoints > 4)
        {
            rollSlider.value = rollSlider.value + 1;
            skillPointsHandler.skillPoints = skillPointsHandler.skillPoints - 4;
            // increase roll damage
            bruteAbilityEffects.rollDamage = bruteAbilityEffects.rollDamage + 2;
        }
    }
}

