using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phaenomys;

/// <summary>
/// Abstract class for Phaenomys (genus).
/// NCBI TaxId: 1560092
/// </summary>
public abstract class Phaenomys : Cricetidae, IPhaenomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaenomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1560092;

    /// <inheritdoc />
    public virtual string GenusName => "Phaenomys";

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
