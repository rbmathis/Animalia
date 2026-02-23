using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Ectophylla;

/// <summary>
/// Abstract class for Ectophylla (genus).
/// NCBI TaxId: 148025
/// </summary>
public abstract class Ectophylla : Phyllostomidae, IEctophylla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ectophylla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148025;

    /// <inheritdoc />
    public virtual string GenusName => "Ectophylla";

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
