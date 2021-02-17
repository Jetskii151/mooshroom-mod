using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MooshroomMod.Items
{
    public class MooshroomSpellBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded item.");
        }

        public override void SetDefaults()
        {
            item.width = 5;
            item.height = 5;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 1;
            item.mana = 12;
            item.damage = 100;
            item.crit = 25;
            item.shoot = ProjectileID.SoulDrain;
            item.shootSpeed = 20;
            item.magic = true;
            item.useStyle = 5;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}