using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Dermanura;

/// <summary>
/// Abstract class for Dermanura (genus).
/// NCBI TaxId: 563992
/// </summary>
public abstract class Dermanura : Phyllostomidae, IDermanura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dermanura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 563992;

    /// <inheritdoc />
    public virtual string GenusName => "Dermanura";

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
