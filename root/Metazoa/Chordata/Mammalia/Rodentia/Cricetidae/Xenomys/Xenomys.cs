using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Xenomys;

/// <summary>
/// Abstract class for Xenomys (genus).
/// NCBI TaxId: 164614
/// </summary>
public abstract class Xenomys : Cricetidae, IXenomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164614;

    /// <inheritdoc />
    public virtual string GenusName => "Xenomys";

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
