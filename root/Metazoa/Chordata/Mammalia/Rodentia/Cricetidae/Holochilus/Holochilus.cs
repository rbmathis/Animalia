using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Holochilus;

/// <summary>
/// Abstract class for Holochilus (genus).
/// NCBI TaxId: 79919
/// </summary>
public abstract class Holochilus : Cricetidae, IHolochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79919;

    /// <inheritdoc />
    public virtual string GenusName => "Holochilus";

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
