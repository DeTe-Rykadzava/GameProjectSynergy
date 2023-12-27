using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public decimal Cost { get; set; }
        
        public Sprite Sprite { get; set; }
        
        public string Description { get; set; }

        private static readonly List<Sprite> Sprites = Items.ItemsSprites.ToList();
        
        private static List<Product> _products = new List<Product>()
            {
                new () // 1
                {
                    Id = 1,
                    Title = "Карта мира",
                    Cost = 50M,
                    Sprite = Sprites[37],
                    Description = "Карта мира великого и багованного TES 5 Skyrim."
                },
                
                new () // 2
                {
                    Id = 2,
                    Title = "Свиток \"Золотой дождь\"",
                    Cost = 100_000M,
                    Sprite = Sprites[32],
                    Description = "Свиток призыва золотого дождя (осторожно не попадите под него)."
                },
                new () // 3
                {
                    Id = 3,
                    Title = "Свиток \"Кислотной жабы\"",
                    Cost = 50M,
                    Sprite = Sprites[34],
                    Description = "Призыв кислотной жабки, больше не опишешь, она ядовита."
                },
                new () // 4
                {
                    Id = 4,
                    Title = "Телепорт",
                    Cost = 100M,
                    Sprite = Sprites[25],
                    Description = "Свиток телепортации в Иссекай к кошко-девочкам."
                },
                new () // 5
                {
                    Id = 5,
                    Title = "Древний манускрипт",
                    Cost = 10_000M,
                    Sprite = Sprites[24],
                    Description = "Древний манускрипт со странными надписями."
                },
                new () // 6
                {
                    Id = 6,
                    Title = "\"Кровавый демон\"",
                    Cost = 1_525M,
                    Sprite = Sprites[21],
                    Description = "Превращает вас в большую и страшную чубаку, временно невосприимчивую к урону."
                },
                new () // 7
                {
                    Id = 7,
                    Title = "Свиток заморозки",
                    Cost = 20_000M,
                    Sprite = Sprites[22],
                    Description = "Заморозит все что рядом с призывателем на расстоянии 50км."
                },
                new () // 8
                {
                    Id = 8,
                    Title = "Темный свиток",
                    Cost = 100M,
                    Sprite = Sprites[36],
                    Description = "Неизвестный темный свиток, никто не знает что он делает. нет плохих отзывов."
                },
                new () // 9
                {
                    Id = 9,
                    Title = "Набор для письма",
                    Cost = 8M,
                    Sprite = Sprites[30],
                    Description = "Можно записать все ваши заметки."
                },
                new () // 10
                {
                    Id = 10,
                    Title = "Египетский свиток",
                    Cost = 2000M,
                    Sprite = Sprites[9],
                    Description = "Старый египетский свиток с непонятными символами, возможно Вы сможете его разгадать."
                },
                new () // 11
                {
                    Id = 11,
                    Title = "Письмо призыва суккуба",
                    Cost = 125M,
                    Sprite = Sprites[27],
                    Description = "*пометка: не читать в публичном месте, даже не вслух*"
                },
                new () // 12
                {
                    Id = 12,
                    Title = "Рецепт \"Человека-Паука\"",
                    Cost = 20_000M,
                    Sprite = Sprites[43],
                    Description = "Даст вам возможность почувствовать себя Человеком-Пауком. *пометка: Не ошибитесь с пауком.*"
                },
                new () // 13
                {
                    Id = 13,
                    Title = "Разрешение на постройку",
                    Cost = 150_000M,
                    Sprite = Sprites[2],
                    Description = "Доказывает ваше право владения определенном участком земли."
                },
                new () // 14
                {
                    Id = 14,
                    Title = "Титул купца",
                    Cost = 100_000M,
                    Sprite = Sprites[3],
                    Description = "Дает вам право покупать оптом и продавать товары."
                },
                new () // 15
                {
                    Id = 15,
                    Title = "Рецепт лилии",
                    Cost = 10M,
                    Sprite = Sprites[48],
                    Description = "Рецепт таинственной и редкой лилии. Использовав его в вы с небольшим шансом вырастите золотистую лилию."
                }
            };
        
        public static List<Product> GetProducts()
        {
            return _products;
        }
    }
}