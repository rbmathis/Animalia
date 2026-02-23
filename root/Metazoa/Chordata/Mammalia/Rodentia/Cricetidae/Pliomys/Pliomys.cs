using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Pliomys;

/// <summary>
/// Abstract class for Pliomys (genus).
/// NCBI TaxId: 3159520
/// </summary>
public abstract class Pliomys : Cricetidae, IPliomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pliomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3159520;

    /// <inheritdoc />
    public virtual string GenusName => "Pliomys";

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
