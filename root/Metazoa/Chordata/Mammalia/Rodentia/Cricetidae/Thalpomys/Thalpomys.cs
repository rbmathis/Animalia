using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thalpomys;

/// <summary>
/// Abstract class for Thalpomys (genus).
/// NCBI TaxId: 240586
/// </summary>
public abstract class Thalpomys : Cricetidae, IThalpomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalpomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240586;

    /// <inheritdoc />
    public virtual string GenusName => "Thalpomys";

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
