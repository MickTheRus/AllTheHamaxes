using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AllTheHamaxes.Items.SilverHamaxe
{
    public class SilverHamaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(silver: 8);

            item.autoReuse = true;
            item.useTime = 18;
            item.useAnimation = 26;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
           
            item.melee = true;
            item.damage = 9;
            item.knockBack = 5.5f;

            item.hammer = 45;
            item.axe = 10;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddIngredient(ItemID.SilverBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}