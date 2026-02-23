using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tarsomys;

/// <summary>
/// Abstract class for Tarsomys (genus).
/// NCBI TaxId: 349712
/// </summary>
public abstract class Tarsomys : Muridae, ITarsomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tarsomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349712;

    /// <inheritdoc />
    public virtual string GenusName => "Tarsomys";

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
