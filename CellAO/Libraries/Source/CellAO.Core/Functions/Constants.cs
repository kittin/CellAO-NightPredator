﻿#region License

// Copyright (c) 2005-2013, CellAO Team
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#endregion

namespace CellAO.Core.Functions
{
    #region Usings ...

    using System;

    #endregion

    /// <summary>
    /// </summary>
    public enum ActionType : int
    {
        /// <summary>
        /// </summary>
        AimedShot = 21, 

        /// <summary>
        /// </summary>
        AMS = 12, 

        /// <summary>
        /// </summary>
        Any = 0, 

        /// <summary>
        /// </summary>
        Attack = 11, 

        /// <summary>
        /// </summary>
        Burst = 22, 

        /// <summary>
        /// </summary>
        Close = 102, 

        /// <summary>
        /// </summary>
        CombatIdle = 16, 

        /// <summary>
        /// </summary>
        CombatIdleEnd = 27, 

        /// <summary>
        /// </summary>
        CombatIdleStart = 26, 

        /// <summary>
        /// </summary>
        Crawl = 20, 

        /// <summary>
        /// </summary>
        DMS = 13, 

        /// <summary>
        /// </summary>
        DoubleAttack = 14, 

        /// <summary>
        /// </summary>
        Drop = 2, 

        /// <summary>
        /// </summary>
        FastAttack = 25, 

        /// <summary>
        /// </summary>
        FlingShot = 28, 

        /// <summary>
        /// </summary>
        FullAuto = 23, 

        /// <summary>
        /// </summary>
        Get = 1, 

        /// <summary>
        /// </summary>
        Idle = 15, 

        /// <summary>
        /// </summary>
        Impact = 31, 

        /// <summary>
        /// </summary>
        LeftAttack = 24, 

        /// <summary>
        /// </summary>
        LeftFoot = 33, 

        /// <summary>
        /// </summary>
        Open = 100, 

        /// <summary>
        /// </summary>
        PlayShiftRequirements = 136, 

        /// <summary>
        /// </summary>
        Repair = 4, 

        /// <summary>
        /// </summary>
        RightFoot = 34, 

        /// <summary>
        /// </summary>
        Run = 18, 

        /// <summary>
        /// </summary>
        Sneak = 19, 

        /// <summary>
        /// </summary>
        SneakAttack = 29, 

        /// <summary>
        /// </summary>
        Split = 10, 

        /// <summary>
        /// </summary>
        Terminate = 30, 

        /// <summary>
        /// </summary>
        ToRemove = 7, 

        /// <summary>
        /// </summary>
        ToTriggerTargetInVicinity = 111, 

        /// <summary>
        /// </summary>
        ToUnwield = 9, 

        /// <summary>
        /// </summary>
        ToUse = 3, 

        /// <summary>
        /// </summary>
        ToWear = 6, 

        /// <summary>
        /// </summary>
        ToWield = 8, 

        /// <summary>
        /// </summary>
        UseItemOnCharacter = 32, 

        /// <summary>
        /// </summary>
        UseItemOnItem = 5, 

        /// <summary>
        /// </summary>
        Walk = 17
    }

    /// <summary>
    /// </summary>
    public enum ArmorSlots : int
    {
        /// <summary>
        /// </summary>
        Back = 3, 

        /// <summary>
        /// </summary>
        Chest = 5, 

        /// <summary>
        /// </summary>
        Feet = 14, 

        /// <summary>
        /// </summary>
        Hands = 8, 

        /// <summary>
        /// </summary>
        Head = 2, 

        /// <summary>
        /// </summary>
        LeftArm = 9, 

        /// <summary>
        /// </summary>
        LeftFinger = 15, 

        /// <summary>
        /// </summary>
        LeftShoulder = 6, 

        /// <summary>
        /// </summary>
        LeftWrist = 12, 

        /// <summary>
        /// </summary>
        Legs = 11, 

        /// <summary>
        /// </summary>
        Neck = 1, 

        /// <summary>
        /// </summary>
        RightArm = 7, 

        /// <summary>
        /// </summary>
        RightFinger = 13, 

        /// <summary>
        /// </summary>
        RightShoulder = 4, 

        /// <summary>
        /// </summary>
        RightWrist = 10
    }

    /// <summary>
    /// </summary>
    [Flags]
    public enum CanFlags : uint
    {
        /// <summary>
        /// </summary>
        AimedShot = 0x1 << 14, 

        /// <summary>
        /// </summary>
        ApplyOnFightingTarget = (uint)0x1 << 31, 

        /// <summary>
        /// </summary>
        ApplyOnFriendly = 0x1 << 21, 

        /// <summary>
        /// </summary>
        ApplyOnHostile = 0x1 << 22, 

        /// <summary>
        /// </summary>
        ApplyOnSelf = 0x1 << 23, 

        /// <summary>
        /// </summary>
        AutoSelect = 0x1 << 20, 

        /// <summary>
        /// </summary>
        Bow = 0x1 << 15, 

        /// <summary>
        /// </summary>
        Brawl = 0x1 << 25, 

        /// <summary>
        /// </summary>
        BreakAndEnter = 0x1 << 8, 

        /// <summary>
        /// </summary>
        Burst = 0x1 << 11, 

        /// <summary>
        /// </summary>
        CanBeParriedRiposted = 0x1 << 30, 

        /// <summary>
        /// </summary>
        CanBeWornWithSocialArmor = 0x1 << 28, 

        /// <summary>
        /// </summary>
        CanParryRiposte = 0x1 << 29, 

        /// <summary>
        /// </summary>
        CantSplit = 0x1 << 24, 

        /// <summary>
        /// </summary>
        Carry = 0x1 << 0, 

        /// <summary>
        /// </summary>
        ConfirmUse = 0x1 << 4, 

        /// <summary>
        /// </summary>
        Consume = 0x1 << 5, 

        /// <summary>
        /// </summary>
        Dimach = 0x1 << 26, 

        /// <summary>
        /// </summary>
        DisarmTraps = 0x1 << 19, 

        /// <summary>
        /// </summary>
        EnableHandAttractors = 0x1 << 27, 

        /// <summary>
        /// </summary>
        FastAttack = 0x1 << 18, 

        /// <summary>
        /// </summary>
        FlingShot = 0x1 << 12, 

        /// <summary>
        /// </summary>
        FullAuto = 0x1 << 13, 

        /// <summary>
        /// </summary>
        NoAmmo = 0x1 << 10, 

        /// <summary>
        /// </summary>
        Sit = 0x1 << 1, 

        /// <summary>
        /// </summary>
        SneakAttack = 0x1 << 17, 

        /// <summary>
        /// </summary>
        Stackable = 0x1 << 9, 

        /// <summary>
        /// </summary>
        ThrowAttack = 0x1 << 16, 

        /// <summary>
        /// </summary>
        TutorChip = 0x1 << 6, 

        /// <summary>
        /// </summary>
        TutorDevice = 0x1 << 7, 

        /// <summary>
        /// </summary>
        Use = 0x1 << 3, 

        /// <summary>
        /// </summary>
        Wear = 0x1 << 2
    }

    /// <summary>
    /// Static class with constants
    /// </summary>
    public static class Constants
    {
        #region Constants

        /// <summary>
        /// </summary>
        public const int EventtypeOnActivate = 10;

        /// <summary>
        /// Event type on close
        /// </summary>
        public const int EventtypeOnClose = 19;

        /// <summary>
        /// Event type on collide
        /// </summary>
        public const int EventtypeOnCollide = 22;

        /// <summary>
        /// Event type on create
        /// </summary>
        public const int EventtypeOnCreate = 7;

        /// <summary>
        /// Event type on effects
        /// </summary>
        public const int EventtypeOnEffects = 8;

        /// <summary>
        /// Event type on end collide
        /// </summary>
        public const int EventtypeOnEndCollide = 23;

        /// <summary>
        /// Event type on endeffect
        /// </summary>
        public const int EventtypeOnEndEffect = 13;

        /// <summary>
        /// Event type on enemy in vicinity
        /// </summary>
        public const int EventtypeOnEnemyInVicinity = 25;

        /// <summary>
        /// Event type on enter
        /// </summary>
        public const int EventtypeOnEnter = 16;

        /// <summary>
        /// Event type on failure
        /// </summary>
        public const int EventtypeOnFailure = 27;

        /// <summary>
        /// Event type on friendly in vicinity
        /// </summary>
        public const int EventtypeOnFriendlyInVicinity = 24;

        /// <summary>
        /// Event type on hit
        /// </summary>
        public const int EventtypeOnHit = 5;

        /// <summary>
        /// Event type on open
        /// </summary>
        public const int EventtypeOnOpen = 18;

        /// <summary>
        /// Event type on repair
        /// </summary>
        public const int EventtypeOnRepair = 1;

        /// <summary>
        /// Event type on run
        /// </summary>
        public const int EventtypeOnRun = 9;

        /// <summary>
        /// Event type on start effect
        /// </summary>
        public const int EventtypeOnStartEffect = 12;

        /// <summary>
        /// Event type on target in vicinity
        /// </summary>
        public const int EventtypeOnTargetInVicinity = 3;

        /// <summary>
        /// Event type on terminate
        /// </summary>
        public const int EventtypeOnTerminate = 20;

        /// <summary>
        /// Event type on trade
        /// </summary>
        public const int EventtypeOnTrade = 37;

        /// <summary>
        /// Event type use item on
        /// </summary>
        public const int EventtypeOnUsItemOn = 4;

        /// <summary>
        /// Event type on use
        /// </summary>
        public const int EventtypeOnUse = 0;

        /// <summary>
        /// Event type on use failed
        /// </summary>
        public const int EventtypeOnUseFailed = 15;

        /// <summary>
        /// Event type on wear
        /// </summary>
        public const int EventtypeOnWear = 14;

        /// <summary>
        /// Event type on wield
        /// </summary>
        public const int EventtypeOnWield = 2;

        /// <summary>
        /// Event type on personal modifier
        /// </summary>
        public const int EventtypePersonalModifier = 26;

        /// <summary>
        /// Expansion Alien invasion
        /// </summary>
        public const int ExpansionAlienInvasion = 0x1 << 3;

        /// <summary>
        /// Expansion Alien invasion preorder
        /// </summary>
        public const int ExpansionAlienInvasionPre = 0x1 << 4;

        /// <summary>
        /// Expansion Legacy of the Xan
        /// </summary>
        public const int ExpansionLegacyOfTheXan = 0x1 << 7;

        /// <summary>
        /// Expansion Legacy of the Xan preorder
        /// </summary>
        public const int ExpansionLegacyOfTheXanPre = 0x1 << 8;

        /// <summary>
        /// Expansion Lost eden
        /// </summary>
        public const int ExpansionLostEden = 0x1 << 5;

        /// <summary>
        /// Expansion Lost eden preorder
        /// </summary>
        public const int ExpansionLostEdenPre = 0x1 << 6;

        /// <summary>
        /// Expansion Notum wars
        /// </summary>
        public const int ExpansionNotumWars = 0x1 << 0;

        /// <summary>
        /// Expansion Shadowlands
        /// </summary>
        public const int ExpansionShadowLands = 0x1 << 1;

        /// <summary>
        /// Expansion Shadowlands preorder
        /// </summary>
        public const int ExpansionShadowLandsPre = 0x1 << 2;

        /// <summary>
        /// Function Type add action
        /// </summary>
        public const int FunctiontypeAddAction = 53182;

        /// <summary>
        /// Function Type add battle station queue
        /// </summary>
        public const int FunctiontypeAddBattleStationQueue = 53222;

        /// <summary>
        /// Function Type add defensive proc
        /// </summary>
        public const int FunctiontypeAddDefProc = 53224;

        /// <summary>
        /// Function Type add difficulty
        /// </summary>
        public const int FunctiontypeAddDifficulty = 53029;

        /// <summary>
        /// Function Type add offensive proc
        /// </summary>
        public const int FunctiontypeAddOffProc = 53227;

        /// <summary>
        /// Function Type add shop item
        /// </summary>
        public const int FunctiontypeAddShopItem = 53043;

        /// <summary>
        /// Function Type add shop item 2
        /// </summary>
        public const int FunctiontypeAddShopItem2 = 53061;

        /// <summary>
        /// Function Type add skill
        /// </summary>
        public const int FunctiontypeAddSkill = 53028;

        /// <summary>
        /// Function Type animation
        /// </summary>
        public const int FunctiontypeAnim = 53025;

        /// <summary>
        /// Function Type animation
        /// </summary>
        public const int FunctiontypeAnimAction = 53047;

        /// <summary>
        /// Function Type animation effect
        /// </summary>
        public const int FunctiontypeAnimEffect = 53003;

        /// <summary>
        /// Function Type area cast nano
        /// </summary>
        public const int FunctiontypeAreaCastNano = 53087;

        /// <summary>
        /// Function Type area hit (AOE damage or heals)
        /// </summary>
        public const int FunctiontypeAreaHit = 53073;

        /// <summary>
        /// Function Type area trigger
        /// </summary>
        public const int FunctiontypeAreaTrigger = 53149;

        /// <summary>
        /// Function Type attractor effect
        /// </summary>
        public const int FunctiontypeAttractorEffect = 53065;

        /// <summary>
        /// Function Type attractor effect 1
        /// </summary>
        public const int FunctiontypeAttractorEffect1 = 53075;

        /// <summary>
        /// Function Type attractor effect 2
        /// </summary>
        public const int FunctiontypeAttractorEffect2 = 53076;

        /// <summary>
        /// Function Type attractor gfx effect
        /// </summary>
        public const int FunctiontypeAttractorGfxEffect = 53204;

        /// <summary>
        /// Function Type attractor mesh
        /// </summary>
        public const int FunctiontypeAttractorMesh = 53055;

        /// <summary>
        /// Function Type audio effect
        /// </summary>
        public const int FunctiontypeAudioEffect = 53011;

        /// <summary>
        /// Function Type back mesh
        /// </summary>
        public const int FunctiontypeBackMesh = 53037;

        /// <summary>
        /// Function Type can fly
        /// </summary>
        public const int FunctiontypeCanFly = 53138;

        /// <summary>
        /// Function Type cast nano
        /// </summary>
        public const int FunctiontypeCastNano = 53051;

        /// <summary>
        /// Function Type cast nano 2
        /// </summary>
        public const int FunctiontypeCastNano2 = 53242;

        /// <summary>
        /// Function Type cast nano if possible
        /// </summary>
        public const int FunctiontypeCastNanoIfPossible = 53206;

        /// <summary>
        /// Function Type cast nano if possible on fight target
        /// </summary>
        public const int FunctiontypeCastNanoIfPossibleOnFightTarget = 53212;

        /// <summary>
        /// Function Type cast stun nano
        /// </summary>
        public const int FunctiontypeCastStunNano = 53089;

        /// <summary>
        /// Function Type cat mesh ??
        /// </summary>
        public const int FunctiontypeCatMesh = 53023;

        /// <summary>
        /// Function Type change action restriction ??
        /// </summary>
        public const int FunctiontypeChangeActionRestriction = 53067;

        /// <summary>
        /// Function Type change body mesh
        /// </summary>
        public const int FunctiontypeChangeBodyMesh = 53054;

        /// <summary>
        /// Function Type change effect
        /// </summary>
        public const int FunctiontypeChangeEffect = 53079;

        /// <summary>
        /// Function Type change variable
        /// </summary>
        public const int FunctiontypeChangeVariable = 53110;

        /// <summary>
        /// Function Type charm npc
        /// </summary>
        public const int FunctiontypeCharmNpc = 53127;

        /// <summary>
        /// Function Type city house enter
        /// </summary>
        public const int FunctiontypeCityHouseEnter = 53218;

        /// <summary>
        /// Function Type clear flag
        /// </summary>
        public const int FunctiontypeClearFlag = 53140;

        /// <summary>
        /// Function Type clone
        /// </summary>
        public const int FunctiontypeClone = 53160;

        /// <summary>
        /// Function Type close npc dialog
        /// </summary>
        public const int FunctiontypeCloseNpcDialog = 53169;

        /// <summary>
        /// Function Type combo name generation
        /// </summary>
        public const int FunctiontypeComboNameGen = 53166;

        /// <summary>
        /// Function Type control hate
        /// </summary>
        public const int FunctiontypeControlHate = 53213;

        /// <summary>
        /// Function Type create apartment
        /// </summary>
        public const int FunctiontypeCreateApartment = 53137;

        /// <summary>
        /// Function Type create city guest key
        /// </summary>
        public const int FunctiontypeCreateCityGuestKey = 53235;

        /// <summary>
        /// Function Type createstat ??
        /// </summary>
        public const int FunctiontypeCreateStat = 53027;

        /// <summary>
        /// Function Type creation
        /// </summary>
        public const int FunctiontypeCreation = 53005;

        /// <summary>
        /// Function Type criteria ??
        /// </summary>
        public const int FunctiontypeCriteria = 53015;

        /// <summary>
        /// Function Type daze
        /// </summary>
        public const int FunctiontypeDaze = 53128;

        /// <summary>
        /// Function Type delayed spawn npc
        /// </summary>
        public const int FunctiontypeDelayedSpawnNpc = 53220;

        /// <summary>
        /// Function Type destroy all humans, ARMAGEDDON
        /// </summary>
        public const int FunctiontypeDestroyAllHumans = 53225;

        /// <summary>
        /// Function Type destroy item
        /// </summary>
        public const int FunctiontypeDestroyItem = 53130;

        /// <summary>
        /// Function Type dialog feedback
        /// </summary>
        public const int FunctiontypeDialogFeedback = 53188;

        /// <summary>
        /// Function Type direct item animation effect
        /// </summary>
        public const int FunctiontypeDirectItemAnimEffect = 53034;

        /// <summary>
        /// Function Type disable defense shield (NW)
        /// </summary>
        public const int FunctiontypeDisableDefenseShield = 53178;

        /// <summary>
        /// Function Type drain hit
        /// </summary>
        public const int FunctiontypeDrainHit = 53185;

        /// <summary>
        /// Function Type end effect
        /// </summary>
        public const int FunctiontypeEndEffect = 53041;

        /// <summary>
        /// Function Type enter apartment
        /// </summary>
        public const int FunctiontypeEnterApartment = 53109;

        /// <summary>
        /// Function Type equip monster weapon
        /// </summary>
        public const int FunctiontypeEquipMonsterWeapon = 53100;

        /// <summary>
        /// Function Type expression
        /// </summary>
        public const int FunctiontypeExpression = 53024;

        /// <summary>
        /// Function Type faction
        /// </summary>
        public const int FunctiontypeFaction = 53189;

        /// <summary>
        /// Function Type fear
        /// </summary>
        public const int FunctiontypeFear = 53121;

        /// <summary>
        /// Function Type generate name
        /// </summary>
        public const int FunctiontypeGenerateName = 53132;

        /// <summary>
        /// Function Type gfx effect
        /// </summary>
        public const int FunctiontypeGfxEffect = 53030;

        /// <summary>
        /// Function Type go to last savepoint
        /// </summary>
        public const int FunctiontypeGoToLastSavePoint = 53144;

        /// <summary>
        /// Function Type hair mesh
        /// </summary>
        public const int FunctiontypeHairMesh = 53036;

        /// <summary>
        /// Function Type head mesh
        /// </summary>
        public const int FunctiontypeHeadMesh = 53035;

        /// <summary>
        /// Function Type head text output
        /// </summary>
        public const int FunctiontypeHeadText = 53057;

        /// <summary>
        /// Function Type hit (stat)
        /// </summary>
        public const int FunctiontypeHit = 53002;

        /// <summary>
        /// Function Type input box
        /// </summary>
        public const int FunctiontypeInputBox = 53115;

        /// <summary>
        /// Function Type instance lock
        /// </summary>
        public const int FunctiontypeInstanceLock = 53231;

        /// <summary>
        /// Function Type instanced player city
        /// </summary>
        public const int FunctiontypeInstancedPlayerCity = 53233;

        /// <summary>
        /// Function Type item animation effect
        /// </summary>
        public const int FunctiontypeItemAnimEffect = 53031;

        /// <summary>
        /// Function Type knock back
        /// </summary>
        public const int FunctiontypeKnockBack = 53230;

        /// <summary>
        /// Function Type land control create
        /// </summary>
        public const int FunctiontypeLandControlCreate = 53173;

        /// <summary>
        /// Function Type line teleportation
        /// </summary>
        public const int FunctiontypeLineTeleport = 53059;

        /// <summary>
        /// Function Type lock perk
        /// </summary>
        public const int FunctiontypeLockPerk = 53187;

        /// <summary>
        /// Function Type lock skill
        /// </summary>
        public const int FunctiontypeLockSkill = 53033;

        /// <summary>
        /// Function Type make vendor shop
        /// </summary>
        public const int FunctiontypeMakeVendorShop = 53074;

        /// <summary>
        /// Function Type set mesh
        /// </summary>
        public const int FunctiontypeMesh = 53004;

        /// <summary>
        /// Function Type mezz
        /// </summary>
        public const int FunctiontypeMezz = 53153;

        /// <summary>
        /// Function Type mind control
        /// </summary>
        public const int FunctiontypeMindControl = 53232;

        /// <summary>
        /// Function Type modify (stats)
        /// </summary>
        public const int FunctiontypeModify = 53045;

        /// <summary>
        /// Function Type modify by % (stats)
        /// </summary>
        public const int FunctiontypeModifyPercentage = 53184;

        /// <summary>
        /// Function Type monster shape ??
        /// </summary>
        public const int FunctiontypeMonsterShape = 53060;

        /// <summary>
        /// Function Type name (set?)
        /// </summary>
        public const int FunctiontypeName = 53048;

        /// <summary>
        /// Function Type next head (char creation)
        /// </summary>
        public const int FunctiontypeNextHead = 53069;

        /// <summary>
        /// Function Type npc apply nano formula
        /// </summary>
        public const int FunctiontypeNpcApplyNanoFormula = 53102;

        /// <summary>
        /// Function Type npc call for help
        /// </summary>
        public const int FunctiontypeNpcCallForHelp = 53120;

        /// <summary>
        /// Function Type npc cast nano if possible
        /// </summary>
        public const int FunctiontypeNpcCastNanoIfPossible = 53215;

        /// <summary>
        /// Function Type npc cast nano if possible on fight target
        /// </summary>
        public const int FunctiontypeNpcCastNanoIfPossibleOnFightTarget = 53216;

        /// <summary>
        /// Function Type npc clear signal
        /// </summary>
        public const int FunctiontypeNpcClearSignal = 53119;

        /// <summary>
        /// Function Type npc clone target
        /// </summary>
        public const int FunctiontypeNpcCloneTarget = 53161;

        /// <summary>
        /// Function Type npc create pet
        /// </summary>
        public const int FunctiontypeNpcCreateOet = 53129;

        /// <summary>
        /// Function Type npc disable movement
        /// </summary>
        public const int FunctiontypeNpcDisableMovement = 53148;

        /// <summary>
        /// Function Type npc enable die of boredom
        /// </summary>
        public const int FunctiontypeNpcEnableDieOfBoredom = 53146;

        /// <summary>
        /// Function Type npc enable ground to air combat
        /// </summary>
        public const int FunctiontypeNpcEnableGroundToAirCombat = 53170;

        /// <summary>
        /// Function Type npc enable pvp rules
        /// </summary>
        public const int FunctiontypeNpcEnablePvpRules = 53172;

        /// <summary>
        /// Function Type npc fake attack on target
        /// </summary>
        public const int FunctiontypeNpcFakeAttackOnTarget = 53145;

        /// <summary>
        /// Function Type npc fight selected target
        /// </summary>
        public const int FunctiontypeNpcFightSelected = 53077;

        /// <summary>
        /// Function Type npc follow selected
        /// </summary>
        public const int FunctiontypeNpcFollowSelected = 53095;

        /// <summary>
        /// Function Type npc freeze hate list
        /// </summary>
        public const int FunctiontypeNpcFreezeHateList = 53195;

        /// <summary>
        /// Function Type npc get target hate list
        /// </summary>
        public const int FunctiontypeNpcGetTargetHateList = 53090;

        /// <summary>
        /// Function Type npc hate list target
        /// </summary>
        public const int FunctiontypeNpcHateListTarget = 53081;

        /// <summary>
        /// Function Type npc hate list target aggroers
        /// </summary>
        public const int FunctiontypeNpcHateListTargetAggroers = 53147;

        /// <summary>
        /// Function Type npc move forward
        /// </summary>
        public const int FunctiontypeNpcMoveForward = 53096;

        /// <summary>
        /// Function Type npc movement action
        /// </summary>
        public const int FunctiontypeNpcMovementAction = 53191;

        /// <summary>
        /// Function Type npc pop script
        /// </summary>
        public const int FunctiontypeNpcPopScript = 53108;

        /// <summary>
        /// Function Type npc push script
        /// </summary>
        public const int FunctiontypeNpcPushScript = 53107;

        /// <summary>
        /// Function Type npc say robot speech
        /// </summary>
        public const int FunctiontypeNpcSayRobotSpeech = 53104;

        /// <summary>
        /// Function Type npc select target
        /// </summary>
        public const int FunctiontypeNpcSelectTarget = 53062;

        /// <summary>
        /// Function Type npc send command
        /// </summary>
        public const int FunctiontypeNpcSendCommand = 53103;

        /// <summary>
        /// Function Type npc send pet status
        /// </summary>
        public const int FunctiontypeNpcSendPetStatus = 53214;

        /// <summary>
        /// Function Type npc send playsync
        /// </summary>
        public const int FunctiontypeNpcSendPlaySync = 53097;

        /// <summary>
        /// Function Type npc set config stats
        /// </summary>
        public const int FunctiontypeNpcSetConfigStats = 53197;

        /// <summary>
        /// Function Type npc set master (pets)
        /// </summary>
        public const int FunctiontypeNpcSetMaster = 53091;

        /// <summary>
        /// Function Type npc set move to target
        /// </summary>
        public const int FunctiontypeNpcSetMoveToTarget = 53198;

        /// <summary>
        /// Function Type npc set sneak mode
        /// </summary>
        public const int FunctiontypeNpcSetSneakMode = 53190;

        /// <summary>
        /// Function Type npc set stuck detect scheme
        /// </summary>
        public const int FunctiontypeNpcSetStuckDetectScheme = 53171;

        /// <summary>
        /// Function Type npc set wandering mode
        /// </summary>
        public const int FunctiontypeNpcSetWanderingMode = 53199;

        /// <summary>
        /// Function Type npc social animation
        /// </summary>
        public const int FunctiontypeNpcSocialAnim = 53078;

        /// <summary>
        /// Function Type npc start surrender
        /// </summary>
        public const int FunctiontypeNpcStartSurrender = 53113;

        /// <summary>
        /// Function Type npc stop moving
        /// </summary>
        public const int FunctiontypeNpcStopMoving = 53116;

        /// <summary>
        /// Function Type npc stop surrender
        /// </summary>
        public const int FunctiontypeNpcStopSurrender = 53114;

        /// <summary>
        /// Function Type npc stop pet duel
        /// </summary>
        public const int FunctiontypeNpcStoppedDuel = 53219;

        /// <summary>
        /// Function Type npc summon enemy
        /// </summary>
        public const int FunctiontypeNpcSummonEnemy = 53163;

        /// <summary>
        /// Function Type npc target has item
        /// </summary>
        public const int FunctiontypeNpcTargetHasItem = 53217;

        /// <summary>
        /// Function Type npc teleport to spawnpoint
        /// </summary>
        public const int FunctiontypeNpcTeleportToSpawnPoint = 53143;

        /// <summary>
        /// Function Type npc toggle fight mode regenerate
        /// </summary>
        public const int FunctiontypeNpcToggleFightModeRegenrate = 53179;

        /// <summary>
        /// Function Type npc toggle fov
        /// </summary>
        public const int FunctiontypeNpcToggleFov = 53183;

        /// <summary>
        /// Function Type npc try group form
        /// </summary>
        public const int FunctiontypeNpcTryGroupForm = 53098;

        /// <summary>
        /// Function Type npc turn to target
        /// </summary>
        public const int FunctiontypeNpcTurnToTarget = 53080;

        /// <summary>
        /// Function Type npc unique players in hate list
        /// </summary>
        public const int FunctiontypeNpcUniquePlayersInHateList = 53203;

        /// <summary>
        /// Function Type npc uses special attack item
        /// </summary>
        public const int FunctiontypeNpcUseSpecialAttackItem = 53194;

        /// <summary>
        /// Function Type npc wipe hate list
        /// </summary>
        public const int FunctiontypeNpcWipeHateList = 53126;

        /// <summary>
        /// Function Type npc kill target
        /// </summary>
        public const int FunctiontypeNpckillTarget = 53131;

        /// <summary>
        /// Function Type open bank
        /// </summary>
        public const int FunctiontypeOpenBank = 53092;

        /// <summary>
        /// Function Type open npc dialog
        /// </summary>
        public const int FunctiontypeOpenNpcDialog = 53168;

        /// <summary>
        /// Function Type org grid
        /// </summary>
        public const int FunctiontypeOrganizationGrid = 53176;

        /// <summary>
        /// Function Type pacify
        /// </summary>
        public const int FunctiontypePacify = 53118;

        /// <summary>
        /// Function Type play music
        /// </summary>
        public const int FunctiontypePlayMusic = 53017;

        /// <summary>
        /// Function Type playfield nano
        /// </summary>
        public const int FunctiontypePlayfieldNano = 53228;

        /// <summary>
        /// Function Type poison
        /// </summary>
        public const int FunctiontypePoison = 53006;

        /// <summary>
        /// Function Type poison remove
        /// </summary>
        public const int FunctiontypePoisonRemove = 53013;

        /// <summary>
        /// Function Type polymorph attack
        /// </summary>
        public const int FunctiontypePolymorphAttack = 53193;

        /// <summary>
        /// Function Type previous head (char creation)
        /// </summary>
        public const int FunctiontypePrevHead = 53070;

        /// <summary>
        /// Function Type proxy teleport with pet handling
        /// </summary>
        public const int FunctiontypeProxyTeleportWithPetHandling = 53165;

        /// <summary>
        /// Function Type radius
        /// </summary>
        public const int FunctiontypeRadius = 53007;

        /// <summary>
        /// Function Type recall to anchor
        /// </summary>
        public const int FunctiontypeRecallToAnchor = 53209;

        /// <summary>
        /// Function Type reduce nano strain duration
        /// </summary>
        public const int FunctiontypeReduceNanoStrainDuration = 53177;

        /// <summary>
        /// Function Type refresh model
        /// </summary>
        public const int FunctiontypeRefreshModel = 53086;

        /// <summary>
        /// Function Type register control point
        /// </summary>
        public const int FunctiontypeRegisterControlPoint = 53223;

        /// <summary>
        /// Function Type remote area trigger
        /// </summary>
        public const int FunctiontypeRemoteAreaTrigger = 53159;

        /// <summary>
        /// Function Type remove
        /// </summary>
        public const int FunctiontypeRemove = 53008;

        /// <summary>
        /// Function Type remove buffs
        /// </summary>
        public const int FunctiontypeRemoveBuffs = 53050;

        /// <summary>
        /// Function Type remove nano 
        /// </summary>
        public const int FunctiontypeRemoveNano = 53201;

        /// <summary>
        /// Function Type remove nano effects
        /// </summary>
        public const int FunctiontypeRemoveNanoEffects = 53105;

        /// <summary>
        /// Function Type remove nano strain
        /// </summary>
        public const int FunctiontypeRemoveNanoStrain = 53236;

        /// <summary>
        /// Function Type remove trigger
        /// </summary>
        public const int FunctiontypeRemoveTrigger = 53174;

        /// <summary>
        /// Function Type reset all perks
        /// </summary>
        public const int FunctiontypeResetAllPerks = 53234;

        /// <summary>
        /// Function Type resist nano strain
        /// </summary>
        public const int FunctiontypeResistNanoStrain = 53162;

        /// <summary>
        /// Function Type restrict action
        /// </summary>
        public const int FunctiontypeRestrictAction = 53068;

        /// <summary>
        /// Function Type random span item
        /// </summary>
        public const int FunctiontypeRndSpawnItem = 53124;

        /// <summary>
        /// Function Type random spawn monster
        /// </summary>
        public const int FunctiontypeRndSpawnMonster = 53125;

        /// <summary>
        /// Function Type runscript
        /// </summary>
        public const int FunctiontypeRunScript = 53221;

        /// <summary>
        /// Function Type save character
        /// </summary>
        public const int FunctiontypeSaveChar = 53032;

        /// <summary>
        /// Function Type save here
        /// </summary>
        public const int FunctiontypeSaveHere = 53164;

        /// <summary>
        /// Function Type scaling modify
        /// </summary>
        public const int FunctiontypeScalingModify = 53175;

        /// <summary>
        /// Function Type set
        /// </summary>
        public const int FunctiontypeSet = 53026;

        /// <summary>
        /// Function Type set anchor
        /// </summary>
        public const int FunctiontypeSetAnchor = 53208;

        /// <summary>
        /// Function Type set flag
        /// </summary>
        public const int FunctiontypeSetFlag = 53139;

        /// <summary>
        /// Function Type set government type
        /// </summary>
        public const int FunctiontypeSetGovernmentType = 53133;

        /// <summary>
        /// Function Type set script config
        /// </summary>
        public const int FunctiontypeSetScriptConfig = 53211;

        /// <summary>
        /// Function Type set state ??
        /// </summary>
        public const int FunctiontypeSetState = 53058;

        /// <summary>
        /// Function Type shophash (our own)
        /// </summary>
        public const int FunctiontypeShophash = 0;

        /// <summary>
        /// Function Type shoulder mesh
        /// </summary>
        public const int FunctiontypeShouldermesh = 53038;

        /// <summary>
        /// Function Type skill
        /// </summary>
        public const int FunctiontypeSkill = 53012;

        /// <summary>
        /// Function Type solve quest
        /// </summary>
        public const int FunctiontypeSolveQuest = 53229;

        /// <summary>
        /// Function Type spawn item
        /// </summary>
        public const int FunctiontypeSpawnItem = 53064;

        /// <summary>
        /// Function Type spawn moster
        /// </summary>
        public const int FunctiontypeSpawnMonster = 53049;

        /// <summary>
        /// Function Type spawn monster 2
        /// </summary>
        public const int FunctiontypeSpawnMonster2 = 53063;

        /// <summary>
        /// Function Type spawn monster rot
        /// </summary>
        public const int FunctiontypeSpawnMonsterRot = 53192;

        /// <summary>
        /// Function Type spawn quest
        /// </summary>
        public const int FunctiontypeSpawnQuest = 53226;

        /// <summary>
        /// Function Type special hit
        /// </summary>
        public const int FunctiontypeSpecialHit = 53196;

        /// <summary>
        /// Function Type start effect
        /// </summary>
        public const int FunctiontypeStartEffect = 53040;

        /// <summary>
        /// Function Type stop music
        /// </summary>
        public const int FunctiontypeStopMusic = 53018;

        /// <summary>
        /// Function Type strmesh
        /// </summary>
        public const int FunctiontypeStrMesh = 53053;

        /// <summary>
        /// Function Type strtexture
        /// </summary>
        public const int FunctiontypeStrTexture = 53052;

        /// <summary>
        /// Function Type stun
        /// </summary>
        public const int FunctiontypeStun = 53122;

        /// <summary>
        /// Function Type summon pet
        /// </summary>
        public const int FunctiontypeSummonPet = 53167;

        /// <summary>
        /// Function Type summon pets
        /// </summary>
        public const int FunctiontypeSummonPets = 53181;

        /// <summary>
        /// Function Type summon player
        /// </summary>
        public const int FunctiontypeSummonPlayer = 53154;

        /// <summary>
        /// Function Type summon teammates
        /// </summary>
        public const int FunctiontypeSummonTeamMates = 53155;

        /// <summary>
        /// Function Type system text
        /// </summary>
        public const int FunctiontypeSystemText = 53044;

        /// <summary>
        /// Function Type talk
        /// </summary>
        public const int FunctiontypeTalk = 53210;

        /// <summary>
        /// Function Type taunt npc
        /// </summary>
        public const int FunctiontypeTauntNpc = 53117;

        /// <summary>
        /// Function Type team cast nano
        /// </summary>
        public const int FunctiontypeTeamCastNano = 53066;

        /// <summary>
        /// Function Type teleport
        /// </summary>
        public const int FunctiontypeTeleport = 53016;

        /// <summary>
        /// Function Type teleport by proxy
        /// </summary>
        public const int FunctiontypeTeleportProxy = 53082;

        /// <summary>
        /// Function Type teleport by proxy 2
        /// </summary>
        public const int FunctiontypeTeleportProxy2 = 53083;

        /// <summary>
        /// Function Type text
        /// </summary>
        public const int FunctiontypeText = 53134;

        /// <summary>
        /// Function Type text effect
        /// </summary>
        public const int FunctiontypeTextEffect = 53009;

        /// <summary>
        /// Function Type texture
        /// </summary>
        public const int FunctiontypeTexture = 53039;

        /// <summary>
        /// Function Type timed effect
        /// </summary>
        public const int FunctiontypeTimedEffect = 53014;

        /// <summary>
        /// Function Type toggle flag
        /// </summary>
        public const int FunctiontypeToggleFlag = 53141;

        /// <summary>
        /// Function Type tracer
        /// </summary>
        public const int FunctiontypeTracer = 53180;

        /// <summary>
        /// Function Type undefined
        /// </summary>
        public const int FunctiontypeUndefined = 53240;

        /// <summary>
        /// Function Type upload nano
        /// </summary>
        public const int FunctiontypeUploadNano = 53019;

        /// <summary>
        /// Function Type visual effect
        /// </summary>
        public const int FunctiontypeVisualEffect = 53010;

        /// <summary>
        /// Function Type waypoint
        /// </summary>
        public const int FunctiontypeWayPoint = 53056;

        /// <summary>
        /// Function Type weapon effect color
        /// </summary>
        public const int FunctiontypeWeaponEffectColor = 53042;

        /// <summary>
        /// Implant slot chest
        /// </summary>
        public const int ImplantslotChest = 5;

        /// <summary>
        /// Implant slot ears
        /// </summary>
        public const int ImplantslotEars = 3;

        /// <summary>
        /// Implant slot eyes
        /// </summary>
        public const int ImplantslotEyes = 1;

        /// <summary>
        /// Implant slot feet
        /// </summary>
        public const int ImplantslotFeet = 13;

        /// <summary>
        /// Implant slot head
        /// </summary>
        public const int ImplantslotHead = 2;

        /// <summary>
        /// Implant slot left arm
        /// </summary>
        public const int ImplantslotLeftarm = 6;

        /// <summary>
        /// Implant slot left hand
        /// </summary>
        public const int ImplantslotLefthand = 12;

        /// <summary>
        /// Implant slot left wrist
        /// </summary>
        public const int ImplantslotLeftwrist = 9;

        /// <summary>
        /// Implant slot legs
        /// </summary>
        public const int ImplantslotLegs = 11;

        /// <summary>
        /// Implant slot right arm
        /// </summary>
        public const int ImplantslotRightarm = 4;

        /// <summary>
        /// Implant slot right hand
        /// </summary>
        public const int ImplantslotRighthand = 10;

        /// <summary>
        /// Implant slot right wrist
        /// </summary>
        public const int ImplantslotRightwrist = 7;

        /// <summary>
        /// Implant slot waist
        /// </summary>
        public const int ImplantslotWaist = 8;

        /// <summary>
        /// Item Flag can be attacked
        /// </summary>
        public const int ItemflagCanBeAttacked = 0x1 << 28;

        /// <summary>
        /// Item Flag can be template item
        /// </summary>
        public const int ItemflagCanBeTemplateItem = 0x1 << 3;

        /// <summary>
        /// Item Flag default target
        /// </summary>
        public const int ItemflagDefaultTarget = 0x1 << 14;

        /// <summary>
        /// Item Flag disable falling
        /// </summary>
        public const int ItemflagDisableFalling = 0x1 << 29;

        /// <summary>
        /// Item Flag disable statel collision
        /// </summary>
        public const int ItemflagDisableStatelCollision = 0x1 << 31;

        /// <summary>
        /// Item Flag has animation
        /// </summary>
        public const int ItemflagHasAnimation = 0x1 << 17;

        /// <summary>
        /// Item Flag has damage
        /// </summary>
        public const int ItemflagHasDamage = 0x1 << 30;

        /// <summary>
        /// Item Flag has energy
        /// </summary>
        public const int ItemflagHasEnergy = 0x1 << 22;

        /// <summary>
        /// Item Flag has multiple count
        /// </summary>
        public const int ItemflagHasMultiplecount = 0x1 << 5;

        /// <summary>
        /// Item Flag has rotation
        /// </summary>
        public const int ItemflagHasRotation = 0x1 << 18;

        /// <summary>
        /// Item Flag has sent first IIR
        /// </summary>
        public const int ItemflagHasSentFirstIir = 0x1 << 21;

        /// <summary>
        /// Item Flag illegal for clan
        /// </summary>
        public const int ItemflagIllegalClan = 0x1 << 24;

        /// <summary>
        /// Item Flag illegal for omni
        /// </summary>
        public const int ItemflagIllegalOmni = 0x1 << 25;

        /// <summary>
        /// Item Flag item social armor
        /// </summary>
        public const int ItemflagItemSocialArmour = 0x1 << 8;

        /// <summary>
        /// Item Flag item texture override
        /// </summary>
        public const int ItemflagItemTextureOverride = 0x1 << 15;

        /// <summary>
        /// Item Flag locked
        /// </summary>
        public const int ItemflagLocked = 0x1 << 6;

        /// <summary>
        /// Item Flag mirror in left hand (two handed weapons?)
        /// </summary>
        public const int ItemflagMirrorInLeftHand = 0x1 << 23;

        /// <summary>
        /// Item Flag modified description
        /// </summary>
        public const int ItemflagModifiedDescription = 0x1 << 1;

        /// <summary>
        /// Item Flag modified name
        /// </summary>
        public const int ItemflagModifiedName = 0x1 << 2;

        /// <summary>
        /// Item Flag nodrop
        /// </summary>
        public const int ItemflagNoDrop = 0x1 << 26;

        /// <summary>
        /// Item Flag no selection indicator
        /// </summary>
        public const int ItemflagNoSelectionIndicator = 0x1 << 10;

        /// <summary>
        /// Item Flag null
        /// </summary>
        public const int ItemflagNull = 0x1 << 16;

        /// <summary>
        /// Item Flag open
        /// </summary>
        public const int ItemflagOpen = 0x1 << 7;

        /// <summary>
        /// Item Flag repulsive
        /// </summary>
        public const int ItemflagRepulsive = 0x1 << 13;

        /// <summary>
        /// Item Flag stationary
        /// </summary>
        public const int ItemflagStationary = 0x1 << 12;

        /// <summary>
        /// Item Flag tell collision
        /// </summary>
        public const int ItemflagTellCollision = 0x1 << 9;

        /// <summary>
        /// Item Flag turn on use
        /// </summary>
        public const int ItemflagTurnOnUse = 0x1 << 4;

        /// <summary>
        /// Item Flag unique
        /// </summary>
        public const int ItemflagUnique = 0x1 << 27;

        /// <summary>
        /// Item Flag use empty destruct
        /// </summary>
        public const int ItemflagUseEmptyDestruct = 0x1 << 11;

        /// <summary>
        /// Item Flag visible
        /// </summary>
        public const int ItemflagVisible = 0x1 << 0;

        /// <summary>
        /// Item Flag wants collision
        /// </summary>
        public const int ItemflagWantCollision = 0x1 << 19;

        /// <summary>
        /// Item Flag wants signals
        /// </summary>
        public const int ItemflagWantSignals = 0x1 << 20;

        /// <summary>
        /// Itemtarget fighting target
        /// </summary>
        public const int ItemtargetFightingtarget = 14;

        /// <summary>
        /// Itemtarget selected target
        /// </summary>
        public const int ItemtargetSelectedtarget = 23;

        /// <summary>
        /// Itemtarget self
        /// </summary>
        public const int ItemtargetSelf = 19;

        /// <summary>
        /// Itemtarget target ??
        /// </summary>
        public const int ItemtargetTarget = 3;

        /// <summary>
        /// Itemtarget user
        /// </summary>
        public const int ItemtargetUser = 1;

        /// <summary>
        /// Itemtarget wearer
        /// </summary>
        public const int ItemtargetWearer = 2;

        /// <summary>
        /// Armor
        /// </summary>
        public const int ItemtypeArmor = 2;

        /// <summary>
        /// Implant
        /// </summary>
        public const int ItemtypeImplant = 3;

        /// <summary>
        /// Misc item type </summary>
        public const int ItemtypeMisc = 0;

        /// <summary>
        /// NPC (or only for NPC's?)
        /// </summary>
        public const int ItemtypeNpc = 4;

        /// <summary>
        /// Spirit
        /// </summary>
        public const int ItemtypeSpirit = 5;

        /// <summary>
        /// Tower
        /// </summary>
        public const int ItemtypeTower = 7;

        /// <summary>
        /// Utility
        /// </summary>
        public const int ItemtypeUtility = 6;

        /// <summary>
        /// Weapon
        /// </summary>
        public const int ItemtypeWeapon = 1;

        /// <summary>
        /// Operator and
        /// </summary>
        public const int OperatorAnd = 4;

        /// <summary>
        /// Operator area target in vicinity
        /// </summary>
        public const int OperatorAreaTargetInVicinity = 60;

        /// <summary>
        /// Operator area zminmax
        /// </summary>
        public const int OperatorAreaZMinMax = 15;

        /// <summary>
        /// Operator bitwise and
        /// </summary>
        public const int OperatorBitAnd = 22;

        /// <summary>
        /// Operator bitwise or
        /// </summary>
        public const int OperatorBitOr = 23;

        /// <summary>
        /// Operator can attack character
        /// </summary>
        public const int OperatorCanAttackChar = 79;

        /// <summary>
        /// Operator can disble defense shield
        /// </summary>
        public const int OperatorCanDisableDefenseShield = 83;

        /// <summary>
        /// Operator can execute formula on target
        /// </summary>
        public const int OperatorCanExecuteFormulaIOnTarget = 59;

        /// <summary>
        /// Operator distance to
        /// </summary>
        public const int OperatorDistanceTo = 51;

        /// <summary>
        /// Operator equals to
        /// </summary>
        public const int OperatorEqualTo = 0;

        /// <summary>
        /// Operator false
        /// </summary>
        public const int OperatorFalse = 99;

        /// <summary>
        /// Operator greater than
        /// </summary>
        public const int OperatorGreaterThan = 2;

        /// <summary>
        /// Operator has changed room while fighting
        /// </summary>
        public const int OperatorHasChangedRoomWhileFighting = 64;

        /// <summary>
        /// Operator has entered non pvp zone
        /// </summary>
        public const int OperatorHasEnteredNonPvpZone = 87;

        /// <summary>
        /// Operator has formula
        /// </summary>
        public const int OperatorHasFormula = 35;

        /// <summary>
        /// Operator has master
        /// </summary>
        public const int OperatorHasMaster = 58;

        /// <summary>
        /// Operator has me on pet list
        /// </summary>
        public const int OperatorHasMeOnPetList = 72;

        /// <summary>
        /// Operator has move to target
        /// </summary>
        public const int OperatorHasMoveToTarget = 96;

        /// <summary>
        /// Operator has not formula
        /// </summary>
        public const int OperatorHasNotFormula = 36;

        /// <summary>
        /// Operator has not perk
        /// </summary>
        public const int OperatorHasNotPerk = 103;

        /// <summary>
        /// Operator has not running nano
        /// </summary>
        public const int OperatorHasNotRunningNano = 101;

        /// <summary>
        /// Operator has not running nano line
        /// </summary>
        public const int OperatorHasNotRunningNanoLine = 102;

        /// <summary>
        /// Operator has not wielded item
        /// </summary>
        public const int OperatorHasNotWieldedItem = 34;

        /// <summary>
        /// Operator has not worn item
        /// </summary>
        public const int OperatorHasNotWornItem = 32;

        /// <summary>
        /// Operator has perk
        /// </summary>
        public const int OperatorHasPerk = 93;

        /// <summary>
        /// Operator has pet pending nano formula
        /// </summary>
        public const int OperatorHasPetPendingNanoFormula = 76;

        /// <summary>
        /// Operator has running nano
        /// </summary>
        public const int OperatorHasRunningNano = 91;

        /// <summary>
        /// Operator has running nano line
        /// </summary>
        public const int OperatorHasRunningNanoLine = 92;

        /// <summary>
        /// Operator has wielded item
        /// </summary>
        public const int OperatorHasWieldedItem = 33;

        /// <summary>
        /// Operator has worn item
        /// </summary>
        public const int OperatorHasWornItem = 31;

        /// <summary>
        /// Operator id (equals i guess)
        /// </summary>
        public const int OperatorId = 9;

        /// <summary>
        /// Operator illegal ??
        /// </summary>
        public const int OperatorIllegal = 25;

        /// <summary>
        /// Operator inventory slot is empty
        /// </summary>
        public const int OperatorInventorySlotIsEmpty = 82;

        /// <summary>
        /// Operator inventory slot is full
        /// </summary>
        public const int OperatorInventorySlotIsFull = 81;

        /// <summary>
        /// Operator is alive
        /// </summary>
        public const int OperatorIsAlive = 40;

        /// <summary>
        /// Operator is anyone looking
        /// </summary>
        public const int OperatorIsAnyoneLooking = 47;

        /// <summary>
        /// Operator is attacked
        /// </summary>
        public const int OperatorIsAttacked = 46;

        /// <summary>
        /// Operator is faction reaction set
        /// </summary>
        public const int OperatorIsFactionReactionSet = 95;

        /// <summary>
        /// Operator is falling
        /// </summary>
        public const int OperatorIsFalling = 89;

        /// <summary>
        /// Operator is fighting
        /// </summary>
        public const int OperatorIsFighting = 45;

        /// <summary>
        /// Operator is flying
        /// </summary>
        public const int OperatorIsFlying = 70;

        /// <summary>
        /// Operator is foe
        /// </summary>
        public const int OperatorIsFoe = 48;

        /// <summary>
        /// Operator is in dungeon
        /// </summary>
        public const int OperatorIsInDungeon = 49;

        /// <summary>
        /// Operator is in no-fighting area
        /// </summary>
        public const int OperatorIsInNoFightingArea = 52;

        /// <summary>
        /// Operator is invalid
        /// </summary>
        public const int OperatorIsInvalid = 39;

        /// <summary>
        /// Operator is location ok
        /// </summary>
        public const int OperatorIsLocationOk = 62;

        /// <summary>
        /// Operator is not too high level
        /// </summary>
        public const int OperatorIsNotTooHighLevel = 63;

        /// <summary>
        /// Operator is npc
        /// </summary>
        public const int OperatorIsNpc = 44;

        /// <summary>
        /// Operator is npc or npc controlled pet
        /// </summary>
        public const int OperatorIsNpcOrNpcControlledPet = 84;

        /// <summary>
        /// Operator is on different playfield
        /// </summary>
        public const int OperatorIsOnDifferentPlayfield = 90;

        /// <summary>
        /// Operator is perk locked
        /// </summary>
        public const int OperatorIsPerkLocked = 94;

        /// <summary>
        /// Operator is perk unlocked
        /// </summary>
        public const int OperatorIsPerkUnlocked = 97;

        /// <summary>
        /// Operator is pet?
        /// </summary>
        public const int OperatorIsPet = 77;

        /// <summary>
        /// Operator is pet overequipped
        /// </summary>
        public const int OperatorIsPetOverEquipped = 75;

        /// <summary>
        /// Operator is player or player controlled pet
        /// </summary>
        public const int OperatorIsPlayerOrPlayerControlledPet = 86;

        /// <summary>
        /// Operator is same as
        /// </summary>
        public const int OperatorIsSameAs = 50;

        /// <summary>
        /// Operator is teleporting
        /// </summary>
        public const int OperatorIsTeleporting = 69;

        /// <summary>
        /// Operator is tower create allowed
        /// </summary>
        public const int OperatorIsTowerCreateAllowed = 80;

        /// <summary>
        /// Operator is under heavy attack
        /// </summary>
        public const int OperatorIsUnderHeavyAttack = 61;

        /// <summary>
        /// Operator is valid
        /// </summary>
        public const int OperatorIsValid = 38;

        /// <summary>
        /// Operator is within vicinity
        /// </summary>
        public const int OperatorIsWithinVicinity = 41;

        /// <summary>
        /// Operator is within weapon range
        /// </summary>
        public const int OperatorIsWithinWeaponrange = 43;

        /// <summary>
        /// Operator item anim
        /// </summary>
        public const int OperatorItemAnim = 17;

        /// <summary>
        /// Operator item has (have it in inventory or item has stat value??)
        /// </summary>
        public const int OperatorItemHas = 7;

        /// <summary>
        /// Operator item has not
        /// </summary>
        public const int OperatorItemHasnot = 8;

        /// <summary>
        /// Operator kull number of ???
        /// </summary>
        public const int OperatorKullNumberOf = 65;

        /// <summary>
        /// Operator less than
        /// </summary>
        public const int OperatorLessThan = 1;

        /// <summary>
        /// Operator min max level compare
        /// </summary>
        public const int OperatorMinMaxLevelCompare = 54;

        /// <summary>
        /// Operator monster template
        /// </summary>
        public const int OperatorMonsterTemplate = 57;

        /// <summary>
        /// Operator not
        /// </summary>
        public const int OperatorNot = 42;

        /// <summary>
        /// Operator not bit and
        /// </summary>
        public const int OperatorNotBitAnd = 107;

        /// <summary>
        /// Operator number of items
        /// </summary>
        public const int OperatorNumberOfItems = 67;

        /// <summary>
        /// Operator obtained item
        /// </summary>
        public const int OperatorObtainedItem = 108;

        /// <summary>
        /// Operator on caster
        /// </summary>
        public const int OperatorOnCaster = 100;

        /// <summary>
        /// Operator on general beholder
        /// </summary>
        public const int OperatorOnGeneralBeholder = 37;

        /// <summary>
        /// Operator on invalid target ??
        /// </summary>
        public const int OperatorOnInvalidTarget = 28;

        /// <summary>
        /// Operator on invalid user
        /// </summary>
        public const int OperatorOnInvalidUser = 30;

        /// <summary>
        /// Operator on secondary item
        /// </summary>
        public const int OperatorOnSecondaryItem = 21;

        /// <summary>
        /// Operator on self
        /// </summary>
        public const int OperatorOnSelf = 19;

        /// <summary>
        /// Operator on target
        /// </summary>
        public const int OperatorOnTarget = 18;

        /// <summary>
        /// Operator on user
        /// </summary>
        public const int OperatorOnUser = 26;

        /// <summary>
        /// Operator on valid target
        /// </summary>
        public const int OperatorOnValidTarget = 27;

        /// <summary>
        /// Operator on valid user
        /// </summary>
        public const int OperatorOnValidUser = 29;

        /// <summary>
        /// Operator or
        /// </summary>
        public const int OperatorOr = 3;

        /// <summary>
        /// Operator primary item
        /// </summary>
        public const int OperatorPrimaryItem = 13;

        /// <summary>
        /// Operator primary template
        /// </summary>
        public const int OperatorPrimaryTemplate = 68;

        /// <summary>
        /// Operator same as selected target
        /// </summary>
        public const int OperatorSameAsSelectedTarget = 85;

        /// <summary>
        /// Operator scan for stat
        /// </summary>
        public const int OperatorScanForStat = 71;

        /// <summary>
        /// Operator secondary item
        /// </summary>
        public const int OperatorSecondaryItem = 14;

        /// <summary>
        /// Operator signal
        /// </summary>
        public const int OperatorSignal = 20;

        /// <summary>
        /// Operator target id (equals i guess)
        /// </summary>
        public const int OperatorTargetId = 10;

        /// <summary>
        /// Operator target signal 
        /// </summary>
        public const int OperatorTargetSignal = 11;

        /// <summary>
        /// Operator target stat
        /// </summary>
        public const int OperatorTargetStat = 12;

        /// <summary>
        /// Operator template compare
        /// </summary>
        public const int OperatorTemplateCompare = 53;

        /// <summary>
        /// Operator test num pets
        /// </summary>
        public const int OperatorTestNumPets = 66;

        /// <summary>
        /// Operator time larger
        /// </summary>
        public const int OperatorTimeLarger = 6;

        /// <summary>
        /// Operator time less (timers til next trigger)
        /// </summary>
        public const int OperatorTimeLess = 5;

        /// <summary>
        /// Operator trickle down larget
        /// </summary>
        public const int OperatorTrickleDownLarger = 73;

        /// <summary>
        /// Operator trickle down less
        /// </summary>
        public const int OperatorTrickleDownLess = 74;

        /// <summary>
        /// Operator true
        /// </summary>
        public const int OperatorTrue = 98;

        /// <summary>
        /// Operator unequal
        /// </summary>
        public const int OperatorUnequal = 24;

        /// <summary>
        /// Operator use location
        /// </summary>
        public const int OperatorUseLocation = 88;

        /// <summary>
        /// Operator user
        /// </summary>
        public const int OperatorUser = 16;

        /// <summary>
        /// Weaponslot belt
        /// </summary>
        public const int WeaponslotBelt = 7;

        /// <summary>
        /// Weaponslot hud1
        /// </summary>
        public const int WeaponslotHud1 = 1;

        /// <summary>
        /// Weaponslot hud 2
        /// </summary>
        public const int WeaponslotHud2 = 15;

        /// <summary>
        /// Weaponslot hud3
        /// </summary>
        public const int WeaponslotHud3 = 2;

        /// <summary>
        /// Weaponslot left hand
        /// </summary>
        public const int WeaponslotLeftHand = 8;

        /// <summary>
        /// Weaponslot NCU 1
        /// </summary>
        public const int WeaponslotNcu1 = 9;

        /// <summary>
        /// Weaponslot NCU 2
        /// </summary>
        public const int WeaponslotNcu2 = 10;

        /// <summary>
        /// Weaponslot NCU 3
        /// </summary>
        public const int WeaponslotNcu3 = 11;

        /// <summary>
        /// Weaponslot NCU 4
        /// </summary>
        public const int WeaponslotNcu4 = 12;

        /// <summary>
        /// Weaponslot NCU 5
        /// </summary>
        public const int WeaponslotNcu5 = 13;

        /// <summary>
        /// Weaponslot NCU 6
        /// </summary>
        public const int WeaponslotNcu6 = 14;

        /// <summary>
        /// Weaponslot right hand
        /// </summary>
        public const int WeaponslotRighthand = 6;

        /// <summary>
        /// Weaponslot utility 1
        /// </summary>
        public const int WeaponslotUtil1 = 3;

        /// <summary>
        /// Weaponslot uilitiy 2
        /// </summary>
        public const int WeaponslotUtil2 = 4;

        /// <summary>
        /// Weaponslot utility 3
        /// </summary>
        public const int WeaponslotUtil3 = 5;

        #endregion
    }

    #region Requirement Check constants

    /// <summary>
    /// Enumeration of the different checking types
    /// doCheckReqs = full requirement check
    /// dontCheckReqs = dont do any requirement check
    /// doEquipCheckReqs = do checks needed while loading inventory at character load (Breed check, Profession check etc)
    /// </summary>
    public enum CheckReqs
    {
        /// <summary>
        /// Do a full requirement check
        /// </summary>
        doCheckReqs, 

        /// <summary>
        /// Dont do requirement check
        /// </summary>
        dontCheckReqs, 

        /// <summary>
        /// do checks needed while loading inventory at character load (Breed check, Profession check etc)
        /// </summary>
        doEquipCheckReqs
    }

    #endregion
}