using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wiedomys;

/// <summary>
/// Abstract class for Wiedomys (genus).
/// NCBI TaxId: 89129
/// </summary>
public abstract class Wiedomys : Cricetidae, IWiedomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wiedomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89129;

    /// <inheritdoc />
    public virtual string GenusName => "Wiedomys";

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
