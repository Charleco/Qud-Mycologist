using XRL;
using XRL.World;
using XRL.World.Effects;

[PlayerMutator]
public class FungiPlayerMutator : IPlayerMutator
{
    public void mutate(GameObject player)
    {
        if(player.GetSubtype()).Equals("Mycologist")
        {
        FungalSporeInfection.ApplyFungalInfection(player, "WaxInfection");
        FungalSporeInfection.ApplyFungalInfection(player, "LuminousInfection");
        FungalSporeInfection.ApplyFungalInfection(player, "MumblesInfection");
        FungalSporeInfection.ApplyFungalInfection(player, "PuffInfection");
        }
    }
}