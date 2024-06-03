using System.Collection;
using System.Collection.Generic;

public class LevelUp
{
    public int level;
    private float experience;
    private float experienceRequired;
    public float hp;

    void Start()
    {
        level = 1;
        hp = 100;
        experience = 0;
    }
    void Update()
    {
        Exp();
        if(Input.GetKeyDown(KeyCode.E))
        {
            experience += 100;
        }
    }

    void RankUp()
    {
        level += 1;
        experience = 0

        switch (level)
        {
            case 2:
                Common += 5;
                uncommon +=5;
                experienceRequired = 200;
                break
        }
    }

    void Exp()
    {
        if (experience >= experienceRequired)
            RankUp();
    }
}