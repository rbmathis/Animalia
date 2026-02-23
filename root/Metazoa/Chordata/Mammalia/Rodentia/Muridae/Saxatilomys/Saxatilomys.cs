using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Saxatilomys;

/// <summary>
/// Abstract class for Saxatilomys (genus).
/// NCBI TaxId: 1268276
/// </summary>
public abstract class Saxatilomys : Muridae, ISaxatilomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saxatilomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1268276;

    /// <inheritdoc />
    public virtual string GenusName => "Saxatilomys";

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
