using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Chiroderma;

/// <summary>
/// Abstract class for Chiroderma (genus).
/// NCBI TaxId: 27645
/// </summary>
public abstract class Chiroderma : Phyllostomidae, IChiroderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiroderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27645;

    /// <inheritdoc />
    public virtual string GenusName => "Chiroderma";

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
