using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Uroderma;

/// <summary>
/// Abstract class for Uroderma (genus).
/// NCBI TaxId: 27662
/// </summary>
public abstract class Uroderma : Phyllostomidae, IUroderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uroderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27662;

    /// <inheritdoc />
    public virtual string GenusName => "Uroderma";

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
