using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Archboldomys;

/// <summary>
/// Abstract class for Archboldomys (genus).
/// NCBI TaxId: 237994
/// </summary>
public abstract class Archboldomys : Muridae, IArchboldomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archboldomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237994;

    /// <inheritdoc />
    public virtual string GenusName => "Archboldomys";

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
