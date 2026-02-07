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
                "Ameller niyetlere göredir. Herkese niyet ettiğinin karşılığı vardır.",
                "Buhârî, Bedü'l-Vahy 1"
            },
            new[] {
                "Müslüman, elinden ve dilinden Müslümanların güvende olduğu kimsedir.",
                "Buhârî, Îmân 4"
            },
            new[] {
                "Sizden biriniz, kendisi için sevdiğini kardeşi için de sevmedikçe gerçek anlamda iman etmiş olmaz.",
                "Buhârî, Îmân 7"
            },
            new[] {
                "Kolaylaştırınız, zorlaştırmayınız. Müjdeleyiniz, nefret ettirmeyiniz.",
                "Buhârî, İlim 11"
            },
            new[] {
                "Güzel söz sadakadır.",
                "Buhârî, Edeb 34"
            },
            new[] {
                "Kim Allah'a ve ahiret gününe inanıyorsa, ya hayır söylesin ya da sussun.",
                "Buhârî, Edeb 31"
            },
            new[] {
                "İnsanların en hayırlısı, insanlara en faydalı olandır.",
                "Taberânî"
            },
            new[] {
                "Güler yüzle kardeşini karşılaman da bir sadakadır.",
                "Tirmizî, Birr 36"
            },
            new[] {
                "Merhamet etmeyene merhamet olunmaz.",
                "Buhârî, Edeb 18"
            },
            new[] {
                "Temizlik imanın yarısıdır.",
                "Müslim, Tahâret 1"
            },
            new[] {
                "Allah sizin suretlerinize ve mallarınıza değil, kalplerinize ve amellerinize bakar.",
                "Müslim, Birr 34"
            },
            new[] {
                "Kuvvetli olan, güreşte yenen değil, öfke anında kendine hâkim olandır.",
                "Buhârî, Edeb 76"
            },
            new[] {
                "İlim öğrenmek her Müslümana farzdır.",
                "İbn Mâce, Mukaddime 17"
            },
            new[] {
                "Hayâ imandandır.",
                "Buhârî, Îmân 16"
            },
            new[] {
                "Allah güzeldir, güzeli sever.",
                "Müslim, Îmân 147"
            },
            new[] {
                "Allah'ın kullarına en sevimli amel, az da olsa devamlı olanıdır.",
                "Buhârî, Rikâk 18"
            },
            new[] {
                "Bir kimse Allah için mütevâzı olursa, Allah onu yükseltir.",
                "Müslim, Birr 69"
            },
            new[] {
                "Sabır, acı bir olayın ilk anında gösterilendir.",
                "Buhârî, Cenâiz 32"
            },
            new[] {
                "Komşusu açken tok yatan bizden değildir.",
                "Hâkim, Müstedrek"
            },
            new[] {
                "Küçüklerimize merhamet etmeyen, büyüklerimize saygı göstermeyen bizden değildir.",
                "Tirmizî, Birr 15"
            },
            new[] {
                "Mümin, mümin için bir binanın tuğlaları gibidir; birbirini sımsıkı tutar.",
                "Buhârî, Salât 88"
            },
            new[] {
                "Kim bir Müslümanın dünya sıkıntılarından birini giderirse, Allah da onun kıyamet sıkıntılarından birini giderir.",
                "Müslim, Birr 36"
            },
            new[] {
                "Dünya müminin zindanı, kâfirin cennetidir.",
                "Müslim, Zühd 1"
            },
            new[] {
                "En hayırlınız, Kur'an'ı öğrenen ve öğretendir.",
                "Buhârî, Fedâilü'l-Kur'ân 21"
            },
            new[] {
                "Her kim sabah ve akşam 'Sübhanallahi ve bihamdihi' derse günahları deniz köpüğü kadar olsa bile bağışlanır.",
                "Buhârî, Deavât 65"
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
