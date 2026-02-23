using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Brachyphylla;

/// <summary>
/// Abstract class for Brachyphylla (genus).
/// NCBI TaxId: 9420
/// </summary>
public abstract class Brachyphylla : Phyllostomidae, IBrachyphylla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyphylla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9420;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyphylla";

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
