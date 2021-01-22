using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AllTheHamaxes.Items.LeadHamaxe
{
    public class LeadHamaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(silver: 4, copper: 80);

            item.autoReuse = true;
            item.useTime = 19;
            item.useAnimation = 28;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
           
            item.melee = true;
            item.damage = 8;
            item.knockBack = 4.5f;

            item.hammer = 43;
            item.axe = 10;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}