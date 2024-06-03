using System;
using System.Collections.Generic;
using Interface;

public class PlayerData : IPlayer
{
    public int PlayerId { get; private set; }
    public string PlayerName { get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public int ExperienceRequired { get; private set; }
    public int HeroPossession { get; private set; }
    public int PlayerHp { get; private set; }
    public int WinStreak { get; private set; }
    private Dictionary<int, bool> roundResult;
    public bool IsWinningGame { get; private set; }

    public PlayerData(int playerId, string playerName, int gold, int level, int experience, int playerHp)
    {
        PlayerId = playerId;
        PlayerName = playerName;
        Gold = gold;
        Level = level;
        Experience = experience;
        PlayerHp = playerHp;
        roundResult = new Dictionary<int, bool>();
        IsWinningGame = false;
    }

    public bool SetRoundResult(int round, bool result)
    {
        roundResult[round] = result;
        return result;
    }

    public void ReceiveDirectDamage(int atkDamage)
    {
        PlayerHp -= atkDamage;
        Console.WriteLine($"You got {atkDamage} damage");
    }

    public bool UpdatePlayerGold(int gold)
    {
        Gold += gold;
        return true;
    }

    public bool UpdatePlayerLevel(int level)
    {
        Level += level;
        HeroPossession++;
        ExperienceRequired += 5;
        Console.WriteLine($"Player has leveled up to {Level}");
        return true;
    }

    public bool UpdatePlayerExperience(int experience, int experienceRequired)
    {
        Experience += experience;
        if (Experience >= experienceRequired)
        {
            UpdatePlayerLevel(Level);
            return true;
        }
        return false;
    }

    public bool UpdateWinStreak(int winStreak)
    {
        if (winStreak > WinStreak)
        {
            WinStreak = winStreak;
            return true;
        }
        return false;
    }

    public bool UpdateIsWinning(bool isWinningGame)
    {
        IsWinningGame = isWinningGame;
        return isWinningGame;
    }
}
