namespace Latihan_4;
public class Character
{
   public static void Status(in string name, ref int level, out string job)
    {
    // refparameter dapat diubah
    level += 1;

    // inParameter tidak dapat diubah atau read only

    //outParameter  harus di inisialisasi
    job = "Warrior";
    }
}