using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.UI;

namespace MoreKatana.Items.Katana
{
    /// <summary>
    /// 近接かつ単純な刀作成時に使う抽象クラス
    /// </summary>
    public abstract class Basic_Katana : ModItem
    {
        public override void AutoDefaults()
        {
            base.AutoDefaults();
            Item.width = 32;
            Item.height = 32;


            Item.useStyle = ItemUseStyleID.Swing;
            Item.DamageType = DamageClass.Melee;//近接ダメージ
            Item.autoReuse = true;//オートスイング
            Item.rare = ItemRarityID.Blue;//最低でも文字色を青色にする（溶岩で燃えないように）
            Item.UseSound = SoundID.Item1;//いわゆる「剣を振ったりしたときの音」が鳴る
        }


    }
}
