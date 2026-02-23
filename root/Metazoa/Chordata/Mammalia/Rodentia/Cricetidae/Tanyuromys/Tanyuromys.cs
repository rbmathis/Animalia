using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tanyuromys;

/// <summary>
/// Abstract class for Tanyuromys (genus).
/// NCBI TaxId: 2304083
/// </summary>
public abstract class Tanyuromys : Cricetidae, ITanyuromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tanyuromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2304083;

    /// <inheritdoc />
    public virtual string GenusName => "Tanyuromys";

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
