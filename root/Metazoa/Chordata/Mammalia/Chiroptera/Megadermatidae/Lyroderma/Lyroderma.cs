using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Lyroderma;

/// <summary>
/// Abstract class for Lyroderma (genus).
/// NCBI TaxId: 3371052
/// </summary>
public abstract class Lyroderma : Megadermatidae, ILyroderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyroderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371052;

    /// <inheritdoc />
    public virtual string GenusName => "Lyroderma";

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
