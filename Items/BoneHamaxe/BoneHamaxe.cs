using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;


namespace AllTheHamaxes.Items.BoneHamaxe
{
    public class BoneHamaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(silver: 24);

            item.autoReuse = true;
            item.useTime = 15;
            item.useAnimation = 23;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 10;
            item.knockBack = 4.5f;
                
            item.hammer = 60;
            item.axe = 12;
        }
    }
    class Gay : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Skeleton)
            {
                if (Main.rand.Next(200) < 1)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneHamaxe"));
            }

            if (npc.type == NPCID.UndeadMiner)
            {
                if (Main.rand.Next(20) < 1)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneHamaxe"));
            }

        }
    }







} 


