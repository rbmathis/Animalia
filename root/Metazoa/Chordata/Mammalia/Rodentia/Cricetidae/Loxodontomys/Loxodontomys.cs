using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Loxodontomys;

/// <summary>
/// Abstract class for Loxodontomys (genus).
/// NCBI TaxId: 2819045
/// </summary>
public abstract class Loxodontomys : Cricetidae, ILoxodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2819045;

    /// <inheritdoc />
    public virtual string GenusName => "Loxodontomys";

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
