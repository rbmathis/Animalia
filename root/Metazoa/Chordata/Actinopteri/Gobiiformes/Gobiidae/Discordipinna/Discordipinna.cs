using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Discordipinna;

/// <summary>
/// Abstract class for Discordipinna (genus).
/// NCBI TaxId: 1365681
/// </summary>
public abstract class Discordipinna : Gobiidae, IDiscordipinna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Discordipinna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365681;

    /// <inheritdoc />
    public virtual string GenusName => "Discordipinna";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
