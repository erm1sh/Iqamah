using System;

namespace Iqamah
{
    /// <summary>
    /// Her gün değişen hadis-i şerif ve hikmetli sözler.
    /// 30 saniyelik döngü ile tüm hadisleri gösterir.
    /// </summary>
    internal static class GunlukIcerik
    {
        private static readonly string[][] Hadisler = new string[][]
        {
    new[] {
        "Actions are only by intentions, and every person will have only what they intended.",
        "Bukhari, Bed' al-Wahy 1"
    },
    new[] {
        "A Muslim is the one from whose tongue and hand other Muslims are safe.",
        "Bukhari, Iman 4"
    },
    new[] {
        "None of you truly believes until he loves for his brother what he loves for himself.",
        "Bukhari, Iman 7"
    },
    new[] {
        "Make things easy and do not make them difficult; give glad tidings and do not repel people.",
        "Bukhari, Knowledge 11"
    },
    new[] {
        "A good word is charity.",
        "Bukhari, Adab 34"
    },
    new[] {
        "Whoever believes in Allah and the Last Day should speak good or remain silent.",
        "Bukhari, Adab 31"
    },
    new[] {
        "The best of people are those who are most beneficial to others.",
        "Tabarani"
    },
    new[] {
        "Smiling at your brother is charity.",
        "Tirmidhi, Birr 36"
    },
    new[] {
        "He who does not show mercy will not be shown mercy.",
        "Bukhari, Adab 18"
    },
    new[] {
        "Cleanliness is half of faith.",
        "Muslim, Taharah 1"
    },
    new[] {
        "Allah does not look at your appearance or your wealth, but He looks at your hearts and your deeds.",
        "Muslim, Birr 34"
    },
    new[] {
        "The strong person is not the one who overcomes others in wrestling, but the one who controls himself when angry.",
        "Bukhari, Adab 76"
    },
    new[] {
        "Seeking knowledge is an obligation upon every Muslim.",
        "Ibn Majah, Introduction 17"
    },
    new[] {
        "Modesty is a part of faith.",
        "Bukhari, Iman 16"
    },
    new[] {
        "Allah is beautiful and loves beauty.",
        "Muslim, Iman 147"
    },
    new[] {
        "The most beloved deeds to Allah are those that are consistent, even if they are few.",
        "Bukhari, Riqaq 18"
    },
    new[] {
        "Whoever humbles himself for Allah’s sake, Allah will elevate him.",
        "Muslim, Birr 69"
    },
    new[] {
        "Patience is at the first strike of calamity.",
        "Bukhari, Funerals 32"
    },
    new[] {
        "He is not one of us who sleeps full while his neighbor goes hungry.",
        "Hakim, Mustadrak"
    },
    new[] {
        "He is not one of us who does not show mercy to the young and respect to the elders.",
        "Tirmidhi, Birr 15"
    },
    new[] {
        "The believers are like a structure, each part strengthening the other.",
        "Bukhari, Prayer 88"
    },
    new[] {
        "Whoever relieves a believer of a hardship in this world, Allah will relieve him of a hardship on the Day of Resurrection.",
        "Muslim, Birr 36"
    },
    new[] {
        "This world is a prison for the believer and a paradise for the disbeliever.",
        "Muslim, Zuhd 1"
    },
    new[] {
        "The best among you are those who learn the Qur’an and teach it.",
        "Bukhari, Virtues of the Qur’an 21"
    },
    new[] {
        "Whoever says 'Subhanallahi wa bihamdihi' morning and evening, his sins will be forgiven even if they are like the foam of the sea.",
        "Bukhari, Supplications 65"
    },
        };

        /// <summary>Toplam hadis sayısını döndürür</summary>
        public static int HadisSayisi => Hadisler.Length;

        /// <summary>Bugüne ait hadis-i şerifi döndürür</summary>
        public static (string Metin, string Kaynak) GununHadisi()
        {
            int index = DateTime.Now.DayOfYear % Hadisler.Length;
            return (Hadisler[index][0], Hadisler[index][1]);
        }

        /// <summary>Belirtilen indeksteki hadisi döndürür (döngüsel)</summary>
        public static (string Metin, string Kaynak) HadisGetir(int index)
        {
            int i = ((index % Hadisler.Length) + Hadisler.Length) % Hadisler.Length;
            return (Hadisler[i][0], Hadisler[i][1]);
        }
    }
}
