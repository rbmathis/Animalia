using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phylloderma;

/// <summary>
/// Abstract class for Phylloderma (genus).
/// NCBI TaxId: 148058
/// </summary>
public abstract class Phylloderma : Phyllostomidae, IPhylloderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phylloderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148058;

    /// <inheritdoc />
    public virtual string GenusName => "Phylloderma";

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
