using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.IO;
using Terraria.UI;
using Microsoft.Xna.Framework;

namespace MoreKatana.Items.Katana.Wood
{
    /// <summary>
    /// 木製の刀（木刀）
    /// </summary>
    public class WoodenKatana : Basic_Katana
    {
        public override void SetDefaults()
        {
            Item.width = 50;//アイテム判定の横幅（拾得する際に使用）
            Item.height = 60;//アイテム判定の縦幅（拾得する際に使用）

            Item.crit = 0;//近接武器なのでデフォルトで4%もらえる
            Item.useTime = 15;//アイテムを使用していると扱われる時間
            Item.useAnimation = 15;//アイテムのアニメーションを再生する時間

            Item.damage = 8;//与えるダメージ
            Item.knockBack = 5;//与えるノックバック

            Item.value = Item.sellPrice(copper: 25);//２５カッパーで売却可能
        }

        public override void AddRecipes()
        {
            CreateRecipe()//レシピの登録開始
                .AddIngredient(ItemID.Wood, 10)//木材１０個
                .AddTile(TileID.WorkBenches)//作業台で
                .Register();//製作可能にする
        }
    }
}
