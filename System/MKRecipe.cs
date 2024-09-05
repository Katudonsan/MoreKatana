using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.UI;

namespace MoreKatana.System
{
    public class MKRecipe : ModSystem
    {
        public override void AddRecipes()
        {

            Recipe recipe;

            //デフォルト刀のレシピ追加
            recipe = Recipe.Create(ItemID.Katana);
            recipe.AddIngredient(ItemID.IronBar,10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }

    }
}
