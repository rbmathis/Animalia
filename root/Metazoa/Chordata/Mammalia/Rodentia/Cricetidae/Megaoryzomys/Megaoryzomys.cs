using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Megaoryzomys;

/// <summary>
/// Abstract class for Megaoryzomys (genus).
/// NCBI TaxId: 3371038
/// </summary>
public abstract class Megaoryzomys : Cricetidae, IMegaoryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaoryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371038;

    /// <inheritdoc />
    public virtual string GenusName => "Megaoryzomys";

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
