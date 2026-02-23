using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Megaderma;

/// <summary>
/// Abstract class for Megaderma (genus).
/// NCBI TaxId: 9412
/// </summary>
public abstract class Megaderma : Megadermatidae, IMegaderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9412;

    /// <inheritdoc />
    public virtual string GenusName => "Megaderma";

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
