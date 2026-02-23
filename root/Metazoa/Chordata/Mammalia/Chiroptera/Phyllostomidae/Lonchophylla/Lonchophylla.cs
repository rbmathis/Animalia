using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lonchophylla;

/// <summary>
/// Abstract class for Lonchophylla (genus).
/// NCBI TaxId: 138704
/// </summary>
public abstract class Lonchophylla : Phyllostomidae, ILonchophylla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lonchophylla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 138704;

    /// <inheritdoc />
    public virtual string GenusName => "Lonchophylla";

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
