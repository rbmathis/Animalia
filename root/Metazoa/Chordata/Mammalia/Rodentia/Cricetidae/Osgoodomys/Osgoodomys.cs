using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Osgoodomys;

/// <summary>
/// Abstract class for Osgoodomys (genus).
/// NCBI TaxId: 37439
/// </summary>
public abstract class Osgoodomys : Cricetidae, IOsgoodomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osgoodomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37439;

    /// <inheritdoc />
    public virtual string GenusName => "Osgoodomys";

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
