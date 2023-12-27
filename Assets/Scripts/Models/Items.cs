using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Models
{
    public class Items
    {
        private static Texture2D _texture = Resources.Load("items") as Texture2D;
        private class PositionsAndBoundsSprite
        {
            public Vector2 Position { get; }
            public Vector2 Bounds { get; }

            public PositionsAndBoundsSprite(Vector2 position, Vector2 bounds)
            {
                Position = position;
                Bounds = bounds;
            }
        }
        public static IEnumerable<Sprite> ItemsSprites { get; } = SetSprites();

        private static List<PositionsAndBoundsSprite> _positionsAndBoundsSprites = new List<PositionsAndBoundsSprite>()
        {
            //row 1
            new PositionsAndBoundsSprite(new Vector2(60,   727),  new Vector2(126,126)),            
            new PositionsAndBoundsSprite(new Vector2(187,  727),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(315,  727),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(444,  727),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(572,  727),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(700,  727),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(829,  727),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(957,  727),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(1086, 727),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(1215, 727),  new Vector2(125,126)),    
            
            //row 2
            new PositionsAndBoundsSprite(new Vector2(60,   562),  new Vector2(126,125)),            
            new PositionsAndBoundsSprite(new Vector2(187,  562),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(315,  562),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(444,  562),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(572,  562),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(700,  562),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(829,  562),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(957,  562),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(1086, 562),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(1215, 562),  new Vector2(125,125)),
            
            //row 3
            new PositionsAndBoundsSprite(new Vector2(60,   398),  new Vector2(126,127)),            
            new PositionsAndBoundsSprite(new Vector2(187,  398),  new Vector2(127,127)),            
            new PositionsAndBoundsSprite(new Vector2(315,  398),  new Vector2(128,127)),            
            new PositionsAndBoundsSprite(new Vector2(444,  398),  new Vector2(127,127)),            
            new PositionsAndBoundsSprite(new Vector2(572,  398),  new Vector2(127,127)),            
            new PositionsAndBoundsSprite(new Vector2(700,  398),  new Vector2(128,127)),            
            new PositionsAndBoundsSprite(new Vector2(829,  398),  new Vector2(127,127)),            
            new PositionsAndBoundsSprite(new Vector2(957,  398),  new Vector2(128,127)),            
            new PositionsAndBoundsSprite(new Vector2(1086, 398),  new Vector2(128,127)),            
            new PositionsAndBoundsSprite(new Vector2(1215, 398),  new Vector2(125,127)),
            
            //row 4
            new PositionsAndBoundsSprite(new Vector2(60,   238),  new Vector2(126,125)),            
            new PositionsAndBoundsSprite(new Vector2(187,  238),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(315,  238),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(444,  238),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(572,  238),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(700,  238),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(829,  238),  new Vector2(127,125)),            
            new PositionsAndBoundsSprite(new Vector2(957,  238),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(1086, 238),  new Vector2(128,125)),            
            new PositionsAndBoundsSprite(new Vector2(1215, 238),  new Vector2(125,125)),
            
            //row 5
            new PositionsAndBoundsSprite(new Vector2(60,   78),  new Vector2(126,126)),            
            new PositionsAndBoundsSprite(new Vector2(187,  78),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(315,  78),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(444,  78),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(572,  78),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(700,  78),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(829,  78),  new Vector2(127,126)),            
            new PositionsAndBoundsSprite(new Vector2(957,  78),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(1086, 78),  new Vector2(128,126)),            
            new PositionsAndBoundsSprite(new Vector2(1215, 78),  new Vector2(125,126)),
        }; 

        private static IEnumerable<Sprite> SetSprites()
        {
            foreach (var item in _positionsAndBoundsSprites)
            {
                yield return Sprite.Create(_texture, new Rect(item.Position.x, item.Position.y, item.Bounds.x, item.Bounds.y), Vector2.zero);
            }
            Resources.UnloadUnusedAssets();
        }
    }
}
