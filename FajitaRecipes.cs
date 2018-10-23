using Terraria.ID;
using Terraria.ModLoader;

namespace FajitaRecipes
{
    class FajitaRecipes : Mod
    {
        public FajitaRecipes()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            };
        }

        public override void AddRecipes()
        {
            ModRecipe r1 = new ModRecipe(this);
            r1.AddIngredient(ItemID.LightlessChasms);
            r1.AddTile(TileID.WorkBenches);
            r1.SetResult(ItemID.DeadlandComesAlive);
            r1.AddRecipe();

            ModRecipe r2 = new ModRecipe(this);
            r2.AddIngredient(ItemID.DeadlandComesAlive);
            r2.AddTile(TileID.WorkBenches);
            r2.SetResult(ItemID.LightlessChasms);
            r2.AddRecipe();
        }
    }
}
