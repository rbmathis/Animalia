using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Styloctenium;

/// <summary>
/// Abstract class for Styloctenium (genus).
/// NCBI TaxId: 1091511
/// </summary>
public abstract class Styloctenium : Pteropodidae, IStyloctenium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Styloctenium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1091511;

    /// <inheritdoc />
    public virtual string GenusName => "Styloctenium";

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
