using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AllTheHamaxes.Items.TinHamaxe
{
    public class TinHamaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(silver: 1, copper: 20);

            item.autoReuse = true;
            item.useTime = 20;
            item.useAnimation = 28;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
           
            item.melee = true;
            item.damage = 6;
            item.knockBack = 5.5f;

            item.hammer = 38;
            item.axe = 8;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddIngredient(ItemID.TinBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}