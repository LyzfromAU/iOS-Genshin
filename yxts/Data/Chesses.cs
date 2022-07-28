using System;
using System.Collections.Generic;

namespace yxts.Data
{
    public class Chessess
    {
        private static List<ChessProperties> ChessList = new List<ChessProperties>
        {
            new ChessProperties
            {
                Attack = "EulaAttack",
                Name = "优菈",
                Element = "冰",
                Ultimate = "EulaUltimate",
                Id = 1,
                Country = "M",
                IsGod = false,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "AyakaAttack",
                Name = "神里绫华",
                Element = "冰",
                Ultimate = "AyakaUltimate",
                Id = 2,
                Country = "D",
                IsGod = false,
                Price = 5
            },
            new ChessProperties
            {
                Attack = "HutaoAttack",
                Name = "胡桃",
                Element = "火",
                Ultimate = "HutaoUltimate",
                Id = 3,
                Country = "L",
                IsGod = false,
                Price = 5
            },
            new ChessProperties
            {
                Attack = "ChongyunAttack",
                Name = "重云",
                Element = "冰",
                Ultimate = "ChongyuUltimate",
                Id = 4,
                Country = "L",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "GanyuAttack",
                Name = "甘雨",
                Element = "冰",
                Ultimate = "GanyuUltimate",
                Id = 5,
                Country = "L",
                IsGod = false,
                Price = 5
            },
            new ChessProperties
            {
                Attack = "DionaAttack",
                Name = "迪奥娜",
                Element = "冰",
                Ultimate = "DionaUltimate",
                Id = 6,
                Country = "M",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "XiaogongAttack",
                Name = "宵宫",
                Element = "火",
                Ultimate = "XiaogongUltimate",
                Id = 7,
                Country = "D",
                IsGod = false,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "KleeAttack",
                Name = "可莉",
                Element = "火",
                Ultimate = "KleeUltimate",
                Id = 8,
                Country = "M",
                IsGod = false,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "DilucAttack",
                Name = "迪卢克",
                Element = "火",
                Ultimate = "DilucUltimate",
                Id = 9,
                Country = "M",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "ShenheAttack",
                Name = "申鹤",
                Element = "冰",
                Ultimate = "ShenheUltimate",
                Id = 10,
                Country = "L",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "QiqiAttack",
                Name = "七七",
                Element = "冰",
                Ultimate = "QiqiUltimate",
                Id = 11,
                Country = "L",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "YanfeiAttack",
                Name = "烟绯",
                Element = "火",
                Ultimate = "YanfeiUltimate",
                Id = 12,
                Country = "L",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "BanniteAttack",
                Name = "班尼特",
                Element = "火",
                Ultimate = "BanniteUltimate",
                Id = 13,
                Country = "M",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "XianglingAttack",
                Name = "香菱",
                Element = "火",
                Ultimate = "XianglingUltimate",
                Id = 14,
                Country = "L",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "YelanAttack",
                Name = "夜兰",
                Element = "水",
                Ultimate = "YelanUltimate",
                Id = 15,
                Country = "L",
                IsGod = false,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "ShenlilingrenAttack",
                Name = "神里绫人",
                Element = "水",
                Ultimate = "ShenlilingrenUltimate",
                Id = 16,
                Country = "D",
                IsGod = false,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "XinhaiAttack",
                Name = "心海",
                Element = "水",
                Ultimate = "XinhaiUltimate",
                Id = 17,
                Country = "D",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "MonaAttack",
                Name = "莫娜",
                Element = "水",
                Ultimate = "MonaUltimate",
                Id = 18,
                Country = "M",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "BarbaraAttack",
                Name = "芭芭拉",
                Element = "水",
                Ultimate = "BarbaraUltimate",
                Id = 19,
                Country = "M",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "XingqiuAttack",
                Name = "行秋",
                Element = "水",
                Ultimate = "XingqiuUltimate",
                Id = 20,
                Country = "L",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "YingAttack",
                Name = "雷电将军",
                Element = "雷",
                Ultimate = "YingUltimate",
                Id = 21,
                Country = "D",
                IsGod = true,
                Price = 5
            },
            new ChessProperties
            {
                Attack = "ShenziAttack",
                Name = "八重神子",
                Element = "雷",
                Ultimate = "ShenziUltimate",
                Id = 22,
                Country = "D",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "FisherAttack",
                Name = "菲谢尔",
                Element = "雷",
                Ultimate = "FisherUltimate",
                Id = 23,
                Country = "M",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "LisaAttack",
                Name = "丽莎",
                Element = "雷",
                Ultimate = "LisaUltimate",
                Id = 24,
                Country = "M",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "KeqingAttack",
                Name = "刻晴",
                Element = "雷",
                Ultimate = "KeqingUltimate",
                Id = 25,
                Country = "L",
                IsGod = false,
                Price = 5
            },
            new ChessProperties
            {
                Attack = "BeidouAttack",
                Name = "北斗",
                Element = "雷",
                Ultimate = "BeidouUltimate",
                Id = 26,
                Country = "L",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "RazorAttack",
                Name = "雷泽",
                Element = "雷",
                Ultimate = "RazorUltimate",
                Id = 27,
                Country = "M",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "ZhongliAttack",
                Name = "钟离",
                Element = "岩",
                Ultimate = "ZhongliUltimate",
                Id = 28,
                Country = "L",
                IsGod = true,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "WendiAttack",
                Name = "温迪",
                Element = "风",
                Ultimate = "WendiUltimate",
                Id = 29,
                Country = "M",
                IsGod = true,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "AmberAttack",
                Name = "安柏",
                Element = "火",
                Ultimate = "AmberUltimate",
                Id = 30,
                Country = "M",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "LuoshaliyaAttack",
                Name = "罗莎莉亚",
                Element = "冰",
                Ultimate = "LuoshaliyaUltimate",
                Id = 31,
                Country = "M",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "SayuAttack",
                Name = "早柚",
                Element = "风",
                Ultimate = "SayuUltimate",
                Id = 32,
                Country = "D",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "GinAttack",
                Name = "琴",
                Element = "风",
                Ultimate = "GinUltimate",
                Id = 33,
                Country = "M",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "YunjinAttack",
                Name = "云堇",
                Element = "岩",
                Ultimate = "YunjinUltimate",
                Id = 34,
                Country = "L",
                IsGod = false,
                Price = 2
            },
            new ChessProperties
            {
                Attack = "WanyeAttack",
                Name = "枫原万叶",
                Element = "风",
                Ultimate = "WanyeUltimate",
                Id = 35,
                Country = "D",
                IsGod = false,
                Price = 3
            },
            new ChessProperties
            {
                Attack = "XiaoAttack",
                Name = "魈",
                Element = "风",
                Ultimate = "XiaoUltimate",
                Id = 36,
                Country = "L",
                IsGod = false,
                Price = 4
            },
            new ChessProperties
            {
                Attack = "DuckAttack",
                Name = "达达利亚",
                Element = "水",
                Ultimate = "DuckUltimate",
                Id = 37,
                Country = "L",
                IsGod = false,
                Price = 2
            }
        };

        public static List<ChessProperties> GetChesses()
        {
            return ChessList;
        }
    }
}
