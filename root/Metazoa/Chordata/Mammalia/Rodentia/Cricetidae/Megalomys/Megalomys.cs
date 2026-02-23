using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Megalomys;

/// <summary>
/// Abstract class for Megalomys (genus).
/// NCBI TaxId: 1607756
/// </summary>
public abstract class Megalomys : Cricetidae, IMegalomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1607756;

    /// <inheritdoc />
    public virtual string GenusName => "Megalomys";

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
