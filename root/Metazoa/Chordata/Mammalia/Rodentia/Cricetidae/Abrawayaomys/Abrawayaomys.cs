using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Abrawayaomys;

/// <summary>
/// Abstract class for Abrawayaomys (genus).
/// NCBI TaxId: 1258731
/// </summary>
public abstract class Abrawayaomys : Cricetidae, IAbrawayaomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abrawayaomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1258731;

    /// <inheritdoc />
    public virtual string GenusName => "Abrawayaomys";

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
