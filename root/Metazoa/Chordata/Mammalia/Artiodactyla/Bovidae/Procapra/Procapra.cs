using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Procapra;

/// <summary>
/// Abstract class for Procapra (genus).
/// NCBI TaxId: 59539
/// </summary>
public abstract class Procapra : Bovidae, IProcapra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procapra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59539;

    /// <inheritdoc />
    public virtual string GenusName => "Procapra";

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
