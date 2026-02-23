using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Romerolagus;

/// <summary>
/// Abstract class for Romerolagus (genus).
/// NCBI TaxId: 48088
/// </summary>
public abstract class Romerolagus : Leporidae, IRomerolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Romerolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48088;

    /// <inheritdoc />
    public virtual string GenusName => "Romerolagus";

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
