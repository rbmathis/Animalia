using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Diphylla;

/// <summary>
/// Abstract class for Diphylla (genus).
/// NCBI TaxId: 148077
/// </summary>
public abstract class Diphylla : Phyllostomidae, IDiphylla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diphylla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148077;

    /// <inheritdoc />
    public virtual string GenusName => "Diphylla";

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
