using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oryzomys;

/// <summary>
/// Abstract class for Oryzomys (genus).
/// NCBI TaxId: 29122
/// </summary>
public abstract class Oryzomys : Cricetidae, IOryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29122;

    /// <inheritdoc />
    public virtual string GenusName => "Oryzomys";

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
