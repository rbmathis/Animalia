using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Dicrostonyx;

/// <summary>
/// Abstract class for Dicrostonyx (genus).
/// NCBI TaxId: 85951
/// </summary>
public abstract class Dicrostonyx : Cricetidae, IDicrostonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicrostonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85951;

    /// <inheritdoc />
    public virtual string GenusName => "Dicrostonyx";

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
