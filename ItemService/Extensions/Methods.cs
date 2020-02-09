using ItemService.Models;

namespace ItemService.Extensions
{
    public static class Methods
    {
        public static Item DoesQualityDegradate(this Item _item)
        {
            switch (_item.ItemName.ToLower())
            {
                case "aged brie":
                    _item.Quality ++;
                    break;
                case "backstage passes":
                    if (_item.SellIn < 10 && _item.SellIn >= 5)
                    {
                        _item.Quality += 2;
                    } else if (_item.SellIn < 5 && _item.SellIn > 0)
                    {
                        _item.Quality += 3;
                    } else if (_item.SellIn <= 0)
                    {
                        _item.Quality = 0;
                    }
                    break;
                case "sulfuras":
                    break;
                case "conjured":
                    _item.Quality -= 2;
                    break;
                default:
                    _item.Quality--;
                    break;
            }

            return _item;
        }

        public static Item IsQualityValid(this Item _item)
        {
            if (_item.Quality > 50)
            {
                _item.Quality = 50;
            }

            if (_item.Quality <= 0)
            {
                _item.Quality = 0;
            }
            return _item;
        }

        public static Item CalculateSellIn(this Item _item)
        {
            switch (_item.ItemName.ToLower())
            {
                case "sulfuras":
                    break;
                default:
                    _item.SellIn--;
                    break;
            }

            return _item;
        }
    }
}
